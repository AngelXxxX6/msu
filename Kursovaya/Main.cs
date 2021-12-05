using System.IO;
using System.Text;

namespace Kursovaya
{
    public partial class Main : Form
    {
        public FileStream f = null;
        public FileStream r = null;
        public bool Check = true;
        public bool load = false;
        public string filenameall = "";
        public Main()
        {
            InitializeComponent();
            Help1.Visible = false;

        }

        private void unarchive_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Выберите файл для разархивирования");
            }
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename2 = openFileDialog1.FileName;
            f = new FileStream(filename2, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            string filename4 = openFileDialog1.SafeFileName;
            string filename = filename4.Split('\\')[filename4.Split('\\').Length - 1];
            string format = ".";
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Выберите куда разархивировать файл");
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel) return;

            string dir = folderBrowserDialog1.SelectedPath;
            if (dir[dir.Length - 1] != '\\') dir += '\\';
            string NAME = dir + filename.Substring(0, filename.LastIndexOf('.'));
            int FormatLen = f.ReadByte();
            for (int i = 0; i < FormatLen; ++i)
                format += (char)f.ReadByte();
            if (File.Exists(NAME + format))
            {
                File.Delete(NAME + format);
            }
            r = new FileStream(NAME + format, FileMode.CreateNew);
            while (f.Position < f.Length)
            {
                int BT = f.ReadByte();
                if (BT == 0)
                {
                    BT = f.ReadByte();
                    for (int i = 0; i < (BT); i++)
                    {
                        byte b = (byte)f.ReadByte();
                        r.WriteByte(b);
                    }
                }
                else
                {
                    int V = f.ReadByte();
                    for (int  i = 0;  i < BT;  i++)
                    {
                        r.WriteByte((byte)V);
                    }
                }
               
            }
            if (f != null) f.Close();
            if (r != null) r.Close();
           if(checkBox1.Checked == true)
            {
                MessageBox.Show("Файл успешно разархивирован!!!");
            }
        }

        private void arrchive_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && !load)
            {
                MessageBox.Show("Выберите файл для сжатия");
            }

            if (!load)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filenameall = openFileDialog1.FileName;
            }
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Выберите куда сохранить файл");
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string Format = filenameall.Substring(filenameall.LastIndexOf('.') + 1);
            string v;
            if (!load)
            {
                v = openFileDialog1.SafeFileName.Replace(Format, "de");
            } 
            else
            {
                v = Path.GetFileName(filenameall).Replace(Format, "de");
            }
            string filename2 = folderBrowserDialog1.SelectedPath;
            if (filename2[filename2.Length - 1].ToString() != @"\")
            {
                filename2 += @"\" + v;
            }

            else
            {
                filename2 += v;
            }
            if (File.Exists(filename2))
            {
                File.Delete(filename2);
            }
            

            f = new FileStream(filenameall, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            r = new FileStream(filename2, FileMode.CreateNew);

            

                r.WriteByte((byte)Format.Length);

                for (int i = 0; i < Format.Length; ++i)
                {
                    r.WriteByte((byte)Format[i]);
                }
                List<byte> BT = new List<byte>();

                while (f.Position < f.Length)
                {
                    byte b = (byte)f.ReadByte();
                    if (BT.Count == 0)
                        BT.Add(b);
                    else if (BT[BT.Count - 1] != b)
                    {//// неповторы
                        BT.Add(b);
                        if (BT.Count == 255)
                        {
                            byte[] D = new byte[255];
                            for (int i = 0; i < D.Length; i++)
                            {
                                D[i] = BT[i];
                            }

                            r.WriteByte((byte)0);
                            r.WriteByte((byte)255);
                            r.Write(BT.ToArray(), 0, 255);
                            BT.Clear();
                        }
                    }
                    else
                    {// повторы
                        if (BT.Count > 0)
                        {
                            r.WriteByte((byte)0);
                            r.WriteByte((byte)(BT.Count));
                            r.Write(BT.ToArray(), 0, BT.Count);
                            BT.Clear();
                        }
                        BT.Add(b);
                        while ((b = (byte)f.ReadByte()) == BT[0])
                        {
                            BT.Add(b);
                            if (BT.Count == 255)
                            {
                                r.WriteByte((byte)BT.Count);
                                r.WriteByte(BT[0]);
                                BT.Clear();

                                break;
                            }
                        }
                        if (BT.Count > 0)
                        {

                            r.WriteByte((byte)BT.Count);
                            r.WriteByte(BT[0]);
                            BT.Clear();
                            BT.Add(b);

                        }
                    }

                }
                if (BT.Count > 1)
                {
                    r.WriteByte((byte)0);
                    r.WriteByte((byte)BT.Count);
                    r.Write(BT.ToArray(), 0, BT.Count);
                }


                if (f != null) f.Close();
                if (r != null) r.Close();
            FileInfo FILE = new FileInfo(filenameall);
            FileInfo FILE2 = new FileInfo(filename2);
            if (FILE.Length <= FILE2.Length)
            {
                FILE2.Delete();
                MessageBox.Show("Данный файл сжать невозможно");
            }
            else if(checkBox1.Checked == true)
            {
                MessageBox.Show("Файл успешно сжат!!!");
            }
            filenameall = "";
            load = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Подсказки выключены");

            }
            else
            {   
                MessageBox.Show("Подсказки включены");
            }
        }

       

        

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                filenameall = files[0];
                load = true;
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            
                e.Effect = DragDropEffects.Move;
               
            
           
           
        }

        private void help_Click(object sender, EventArgs e)
        {
            if(Help1.Visible == false)
            {
                Help1.Visible = true;
            }
            else
            {
                Help1.Visible = false;
            }
        }
    }
}