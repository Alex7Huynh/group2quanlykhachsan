using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace QLKS_5Star
{
    class QuanLyDuLieu
    {
        private string _chuoiKetNoi;

        public string ChuoiKetNoi
        {
            get { return _chuoiKetNoi; }
            set { _chuoiKetNoi = value; }
        }
        private XmlDocument _taiLieu;

        public XmlDocument TaiLieu
        {
            get { return _taiLieu; }
            set { _taiLieu = value; }
        }
        public QuanLyDuLieu(string tenFile)
        {
            _chuoiKetNoi = tenFile;
            _taiLieu = new XmlDocument();
            LoadXml();
        }
        //Doc
        public bool LoadXml()
        {
            try
            {
                _taiLieu.Load(_chuoiKetNoi);
                return true;
            }
            catch (System.Exception e)
            {
                return false;
            }
        }
        //Ghi
        public bool SaveXml()
        {
            try
            {
                _taiLieu.Save(_chuoiKetNoi);
                return true;
            }
            catch (System.Exception e)
            {
                return false;
            }
        }
        //Update
        public bool Update(XmlNode newNode, XmlNode oldNode)
        {
            try
            {
                _taiLieu.ReplaceChild(newNode, oldNode);
                return true;
            }
            catch (System.Exception e)
            {
                return false;
            }
        }
        public bool Update(XmlNode Node, String[] valueOfAtts)
        {
            try
            {
                for (int i = 0; i < valueOfAtts.Length; i++)
                {
                    Node.Attributes[i].Value = valueOfAtts[i];
                    SaveXml();
                }
                return true;
            }
            catch (System.Exception e)
            {
                return false;
            }
        }
        //Delete
        public bool Delete(XmlNode node, XmlNode parent)
        {
            try
            {
                parent.RemoveChild(node);
                return true;
            }
            catch (System.Exception e)
            {
                return false;
            }
        }
        public int[][] LaySoDoTinhTrangPhong(int iNgay, int iThang, int iNam)
        {
            XmlNode xmlNam = GetXmlNode("Nam", "Giatri", iNam.ToString());
            int[][] soDoTinhTrangPhong = new int[xmlNam.ChildNodes.Count][];
            
            for (int i = 0; i < xmlNam.ChildNodes.Count; i++ )
            {
                XmlNode xmlPhong = xmlNam.ChildNodes[i];
                soDoTinhTrangPhong[i] = new int[xmlPhong.ChildNodes.Count];
                for (int j = 0; j < xmlPhong.ChildNodes.Count; j++ )
                {
                    XmlElement xmlNgay = (XmlElement)xmlPhong.ChildNodes[j];
                    int soNgayTrong = int.Parse(xmlNgay.GetAttribute("Songaytrong"));
                    soDoTinhTrangPhong[i][j] = soNgayTrong;
                }
            }
            return soDoTinhTrangPhong;
        }
        public void CapNhatSoDoTinhTrangPhong(ref int[][] soDoTinhTrangPhong, int viTriPhong, int viTriNgayThue, int soNgayThue)
        {
            // danh dau so ngay duoc dat phong
            for (int i = viTriNgayThue; i < viTriNgayThue + soNgayThue; i++ )
            {
                soDoTinhTrangPhong[viTriPhong][i] = 0;
            }
            // cap nhat lai tinh trang so do phong
            // vi so ngay trong cua 1 phong chi co gia tri trong khoang 2 ngay khong co phong trong
            // nen ta dem lui, neu ngay hien tai(i) la ngay ko co phong trong thi thoat
            for (int i = viTriNgayThue - 1; i > 0; i-- )
            {
                if (soDoTinhTrangPhong[viTriPhong][i] == 0)
                {
                    return;
                }
                else
                    soDoTinhTrangPhong[viTriPhong][i] -= soNgayThue;
            }
        }
        public void CapNhatCoSoDuLieu(int[][] soDoTinhTrangPhong, int maPhong, int nam, int viTriNgay)
        {
            XmlNode xmlNam = GetXmlNode("Nam", "Giatri", nam.ToString());
            for (int i = 0; i < xmlNam.ChildNodes.Count; i++)
            {
                XmlNode xmlPhong = xmlNam.ChildNodes[i];
                if (xmlPhong.Attributes["Ma"].Value.Equals("00" + (maPhong + 1).ToString()))
                {
                    for (int j = 0; j < xmlPhong.ChildNodes.Count; j++)
                    {
                        xmlPhong.ChildNodes[j].Attributes["Songaytrong"].Value = soDoTinhTrangPhong[maPhong][j].ToString();
                    }
                    SaveXml();
                    return;
                }
            }
            
        }
        public XmlNode GetXmlNode(String nodeName, String attName, String valueOfAtt)
        {
            String xPath = "//" + nodeName + "[@" + attName + "= " + "'" + valueOfAtt + "'" + "]";
            return _taiLieu.SelectSingleNode(xPath);
        }
        /*
        //insert 
        public bool Insert(XmlNode newNode, XmlNode parent)
        {
            try
            {
                parent.AppendChild(newNode);
                return true;
            }
            catch (System.Exception e)
            {
                return false;
            }
        }
        //tao node
        public XmlNode CreateNode(String name, String[] attsName, String[] valueOfAtts)
        {
            try
            {
                XmlElement newNode = _taiLieu.CreateElement(name);
                for (int i = 0; i < attsName.Length; i++)
                {
                    newNode.SetAttribute(attsName[i], valueOfAtts[i]);
                }
                return newNode;
            }
            catch (System.Exception e)
            {
                return null;
            }
        }
        
        public XmlNode GetXmlNode(String parent, String nodeName, String attName, String valueOfAtt)
        {
            String xPath = "//" + parent + "//" + nodeName + "[@" + attName + "= " + "'" + valueOfAtt + "'" + "]";
            return _taiLieu.SelectSingleNode(xPath);
        }
        public XmlNodeList GetXmlNodeList(String nodeName, String attName, String valueOfAtt)
        {
            String xPath = "//" + nodeName + "[@" + attName + "= " + "'" + valueOfAtt + "'" + "]";
            return _taiLieu.SelectNodes(xPath);
        }
        public XmlNodeList GetXmlNodeList(String parent, String nodeName, String attName, String valueOfAtt)
        {
            String xPath = "//" + parent + "//" + nodeName + "[@" + attName + "= " + "'" + valueOfAtt + "'" + "]";
            return _taiLieu.SelectNodes(xPath);
        }
        // lay danh sach gia tri cua 1 node
        public List<String> GetStringList(String name, String att)
        {
            List<String> dsLop = new List<String>();
            String xPath = "//*[name() ='" + name + "']";
            try
            {
                XmlNodeList ds = _taiLieu.SelectNodes(xPath);
                for (int i = 0; i < ds.Count; i++)
                {
                    String ten = ((XmlElement)ds[i]).GetAttribute(att);
                    dsLop.Add(ten);
                }
            }
            catch (System.Exception e)
            {
                dsLop = new List<string>();
            }
            return dsLop;
        }
        public List<String> GetStringList(String parentName, String parentAttName, String valueOfParentAtt, String att)
        {
            List<String> dsLop = new List<String>();
            //String xPath = "//" + parentName + "//*[@ ='" + name + "']";
            try
            {
                XmlNode parent = GetXmlNode(parentName, parentAttName, valueOfParentAtt);
                //XmlNodeList ds = taiLieu.SelectNodes(xPath);

                for (int i = 0; i < parent.ChildNodes.Count; i++)
                {
                    String ten = ((XmlElement)parent.ChildNodes[i]).GetAttribute(att);
                    dsLop.Add(ten);
                }
            }
            catch (System.Exception e)
            {
                dsLop = new List<string>();
            }
            return dsLop;
        }
        public bool FillDataGridView(DataGridView dgv, XmlElement node)
        {
            try
            {
                dgv.Rows.Clear();
                int rows = node.ChildNodes.Count;
                for (int i = 0; i < rows; i++)
                {
                    XmlElement child = (XmlElement)node.ChildNodes[i];
                    object[] dsa = new object[child.Attributes.Count + 1];
                    dsa[0] = (i + 1).ToString();
                    for (int j = 0; j < child.Attributes.Count; j++)
                    {
                        String attName = child.Attributes[j].Name;
                        String att = child.GetAttribute(attName);
                        dsa[j + 1] = att;
                    }
                    //dgv.Rows.Add(dsAtt[0], dsAtt[1], dsAtt[2], dsAtt[3], dsAtt[4]);                    
                    dgv.Rows.Add(dsa);
                }
                return true;
            }
            catch (System.Exception e)
            {
                return false;
            }

        }
        public void FillComboBox(ComboBox cmb, String name, String att)
        {
            List<String> ds = GetStringList(name, att); 
            cmb.DataSource = ds;
            cmb.DisplayMember = ds[0];
        }
        public void FillComboBox(ComboBox cmb, String parentName, String parentAttName, String valueOfParentAtt, String att)
        {
            List<String> ds = GetStringList(parentName, parentAttName, valueOfParentAtt, att);
            cmb.DataSource = ds;
            cmb.DisplayMember = ds[0];
        }*/
    }
}
