using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

using System.Diagnostics;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        string CryptString = "234889";
        string path = @"testt.txt";
        string PWpath= @"pw.txt";
        
        string LoadPassWord = "37759885";

        public Form1()
        {

            InitializeComponent();


        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)//노드설정
        {

            //   treeView1.GetNodeAt(e.X, e.Y).Checked = true;
            if (e.Button.Equals(MouseButtons.Right))
            {
                //     ( treeView1.;


                ;
                /*필요없는거               NodeName = treeView1.GetNodeAt(e.X, e.Y).Text;
                               IDShowBox.Text = NodeName;*/
                ContextMenu NodeRightMenu = new ContextMenu();
                MenuItem RightSetupItem = new MenuItem("설정");
                MenuItem RightAddItem = new MenuItem("추가");
                MenuItem RightRemoveItem = new MenuItem("삭제");
                NodeRightMenu.MenuItems.Add(RightRemoveItem);

                if (treeView1.Nodes.IndexOf(treeView1.SelectedNode) < 0) NodeRightMenu.MenuItems.Add(RightSetupItem);
                if (treeView1.Nodes.IndexOf(treeView1.SelectedNode) >= 0) NodeRightMenu.MenuItems.Add(RightAddItem);
                NodeRightMenu.Show(treeView1, new Point(e.X, e.Y));

                RightSetupItem.Click += (Sender, args) =>
                {
                    setuppanel.Visible = true;
                    setuppanel.Location = new Point(253,26);
                    treeView1.Enabled = false;


                };
                RightAddItem.Click += (Sender, args) =>
                {
                    setuppanel.Visible = true;
                    setuppanel.Location = new Point(253, 26);
                    treeView1.Enabled = false;
                    


                };
                RightRemoveItem.Click += (Sender, args) =>
                {
                   
                    if(MessageBox.Show("정말 지우시겠습니까?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if(treeView1.Nodes.IndexOf(treeView1.SelectedNode) >=0)
                        {
                            if (MessageBox.Show("부모 노드입니다.\n정말 지우시겠습니까?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                treeView1.SelectedNode.Remove();
                            }
                        }
                        else treeView1.SelectedNode.Remove();


                    }
                    
                    

                };


            }


        }

        private void button1_Click(object sender, EventArgs e)//셋업창
        {
            TreeNode NNode = new TreeNode();
            setuppanel.Visible = false;
            treeView1.Enabled = true;
            //0 부모 -1 자식
            string TagData = "";
            NNode.Text = Nbox.Text;
            TagData = IDBox.Text + (char)22;
            TagData += PWBox.Text + (char)23;
            TagData += ADBox.Text + (char)24;
            
            NNode.Tag = TagData;

            Nbox.Text = "";
            IDBox.Text = "";
            PWBox.Text = "";
            ADBox.Text = "";
            if (treeView1.Nodes.IndexOf(treeView1.SelectedNode) >= 0)
            {
                treeView1.SelectedNode.Nodes.Add(NNode);
            }
            else if (treeView1.Nodes.IndexOf(treeView1.SelectedNode) <= -1)
            {
                treeView1.SelectedNode.Text = NNode.Text;
                treeView1.SelectedNode.Tag = NNode.Tag;
            }

            



        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)//노드외부(창바깥)
        {

            if (e.Button.Equals(MouseButtons.Right) && treeView1.HitTest(e.X, e.Y).Location.ToString() != "Label") 
            {
                ContextMenu RightMenu = new ContextMenu();

                MenuItem RightAddItem = new MenuItem("추가");


                
                RightMenu.MenuItems.Add(RightAddItem);

                RightMenu.Show(treeView1, new Point(e.X, e.Y));
                RightAddItem.Click += (Sender, args) =>
                {
                    TreeNode Nnode = new TreeNode();
                    Nnode.Text = "";


                    treeView1.Nodes.Add(Nnode);
                    treeView1.Nodes[treeView1.GetNodeCount(false) - 1].BeginEdit();






                };
            }

        }



        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (LoadPWPanel.Visible==false)
            {
                StreamWriter SaveFile = new StreamWriter(path);



                string TempString = "";
                for (int i = 0; i <= treeView1.GetNodeCount(false) - 1; i++)
                {
                    TempString += treeView1.Nodes[i].Text + (char)20;

                    

                    for (int j = 0; j <= treeView1.Nodes[i].GetNodeCount(false) - 1; j++)
                    {
                        TempString += treeView1.Nodes[i].Nodes[j].Text + (char)21;
                        TempString += (string)treeView1.Nodes[i].Nodes[j].Tag;





                    }
                    

                }
                SaveFile.WriteLine(EncryptString((TempString), CryptString));
                SaveFile.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)//입출력 함수화
        {
            setButton.Enabled = false;
            treeView1.Enabled = false;
            LoadPWPanel.Location = new Point(128, 81);
            
            try
            {
                StreamReader OpenPW = new StreamReader(PWpath);
                LoadPassWord =DecryptString( OpenPW.ReadToEnd(),CryptString);
                OpenPW.Close();

            }
            catch ( FileNotFoundException Exc)
            {
                StreamWriter NewPW = new StreamWriter(PWpath);
                NewPW.WriteLine(EncryptString( LoadPassWord,CryptString) );
                NewPW.Close();
                MessageBox.Show("제작자에게 문의하세요");
            }

        }
        public void CutText(String MainText)//구동이상함
        {
            string temptext = "";

            for (int i = 0; i < MainText.Length; i++)
            {



                if (MainText[i] == (char)20)
                {

                    IDShowBox.Text += temptext + "  ";
                    temptext = "";


                }
                else
                {
                    temptext += MainText[i];
                    
                }
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (treeView1.Nodes.IndexOf(treeView1.SelectedNode) >= 0)
                {
                    IDShowBox.Text = "";
                    PWShowbox.Text = "";
                    AdShowLabel.Text = "Address";
                }

                    if (treeView1.Nodes.IndexOf(treeView1.SelectedNode) < 0)
                {
                    String TempString = "";
                    string ForTemp = "";
                    TempString = (string)treeView1.SelectedNode.Tag;
                    for (int i = 0; i < TempString.Length; i++)
                    {

                        if (TempString[i] == (char)22)
                        {
                            IDShowBox.Text = ForTemp;
                            ForTemp = "";
                        }
                        else if (TempString[i] == (char)23)
                        {
                            PWShowbox.Text = ForTemp.Substring(1);
                            ForTemp = "";
                        }
                        else if (TempString[i] == (char)24)
                        {
                            AdShowLabel.Text = "www."+ForTemp.Substring(1);
                            ForTemp = "";
                        }
                        ForTemp += TempString[i];


                    }


                }
            }
            catch (Exception Exc)
            {
                IDShowBox.Text = "";
                PWShowbox.Text = "";
                AdShowLabel.Text = "Address";

            }
        }

        private void AdShowLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                e.Link.LinkData = AdShowLabel.Text;
                Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception Exc)
            {

            }
        }
        private static string EncryptString(string InputText, string Password)//암호화
        {

            
            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            
            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(InputText);


            byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());

            
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);


            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

             
            MemoryStream memoryStream = new MemoryStream();

            
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

            
            cryptoStream.Write(PlainText, 0, PlainText.Length);

            
            cryptoStream.FlushFinalBlock();

            
            byte[] CipherBytes = memoryStream.ToArray();

            
            memoryStream.Close();
            cryptoStream.Close();

            
            string EncryptedData = Convert.ToBase64String(CipherBytes);

            
            return EncryptedData;
        }
        private static string DecryptString(string InputText, string Password)//복호화
        {
            
            
                RijndaelManaged RijndaelCipher = new RijndaelManaged();
                try
                {
                    byte[] EncryptedData = Convert.FromBase64String(InputText);
                    byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());

                    PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);


                    ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

                    MemoryStream memoryStream = new MemoryStream(EncryptedData);


                    CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);


                    byte[] PlainText = new byte[EncryptedData.Length];


                    int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);

                    memoryStream.Close();
                    cryptoStream.Close();


                    string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);


                    return DecryptedData;
                }

                catch (FormatException Exc)
                {
                    MessageBox.Show("텍스트파일에러");
                    return "";
                }
            catch ( CryptographicException ex)
            {
                return "";
            }
            
        }

        private void PWShowbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadPWButton_Click(object sender, EventArgs e)
        {
            if (LoadPWBox.Text == LoadPassWord)
            {
                LoadPWPanel.Visible = false;
                setButton.Enabled = true;
                treeView1.Enabled = true;
                //데이터 출력

                String TempString = "";
                try
                {
                    StreamReader OpenFile = new StreamReader(path);
                    TempString = DecryptString(OpenFile.ReadToEnd(), CryptString);
                    OpenFile.Close();
                    TreeNode NNode = new TreeNode();
                    TreeNode TempNode = new TreeNode();

                    string forTemp = "";


                    for (int i = 0; i < TempString.Length; i++)
                    {
                        if (TempString[i] != (char)20 && TempString[i] != (char)21)
                        {
                            forTemp += TempString[i];
                        }
                        if (TempString[i] == (char)20)
                        {
                            NNode.Text = forTemp;
                            treeView1.Nodes.Add((TreeNode)NNode.Clone());
                            NNode = TempNode;


                            forTemp = "";


                        }
                        else if (TempString[i] == (char)21)
                        {
                            NNode.Text = forTemp;

                            forTemp = "";
                        }
                        else if (TempString[i] == (char)24)
                        {

                            NNode.Tag = forTemp;
                            treeView1.Nodes[treeView1.GetNodeCount(false) - 1].Nodes.Add((TreeNode)NNode.Clone());
                            NNode = TempNode;


                            forTemp = "";
                        }

                    }


                }
                catch (FileNotFoundException Exc)
                {
                    StreamWriter NewFile = new StreamWriter(path);
                    NewFile.Close();
                }





            }
            else MessageBox.Show("잘못된 비밀번호 입니다", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PWSetButton_Click(object sender, EventArgs e)
        {
            if (PWSetBox.Text==PWSetequalBox.Text)
            {
                PWSetPanel.Visible = false;
                LoadPassWord = PWSetBox.Text;
                PWSetBox.Text = "";
                PWSetequalBox.Text = "";
                StreamWriter SaveFile = new StreamWriter(PWpath);
                try
                {

                    
                    SaveFile.WriteLine(EncryptString( LoadPassWord,CryptString));
                    

                }
                catch(IOException Exc)
                {
                    MessageBox.Show("IO에러");
                }
                finally
                {
                    SaveFile.Close();
                }
            }else MessageBox.Show("비밀번호가 다릅니다", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            PWSetPanel.Visible = true;
            PWSetPanel.Location = new Point(200, 141);
        }

        private void PWSetCancelButton_Click(object sender, EventArgs e)
        {
            PWSetPanel.Visible = false;
            PWSetequalBox.Text = "";
            PWSetBox.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}



/*
 노드추가 완료
 저장 완료
 불러오기 완료
 자식노드 메뉴 "추가" 제거 절반
 노드지우기 시작안함
  
 
 */
