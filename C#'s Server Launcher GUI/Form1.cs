using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using File = System.IO.File;

namespace msch
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        public void reloading()
        {
            try
            {
                //対応versions
                string selserver = serversel.Text;
                var path = Directory.GetCurrentDirectory() + "\\jar\\";
                var files = Directory.GetFiles(path + selserver, "*.jar");
                serverfile.Items.Clear();
                versel.Items.Clear();
                foreach (string file in files)
                {
                    serverfile.Items.Add(file.Replace(path + selserver + "\\", ""));
                    versel.Items.Add(file.Replace(path + selserver + "\\", ""));
                }
                //今あるフォルダの表示
                serverfolder.Items.Clear();
                path = Directory.GetCurrentDirectory() + "\\server";
                string[] arr = Directory.GetDirectories(path);
                foreach (var str in arr)
                {
                    string dir = str.Replace(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\server\\", "");
                    serverfolder.Items.Add(dir);
                }
                //サーバーファイルのあるフォルダの取得とか
                serversel.Items.Clear();
                path = Directory.GetCurrentDirectory() + "\\jar";
                var folders = Directory.GetDirectories(path);
                foreach (string file in folders)
                {
                    serversel.Items.Add(file.Replace(path + "\\", ""));
                }
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void serversel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //対応version
                string selserver = serversel.Text;
                var path = Directory.GetCurrentDirectory() + "\\jar\\";
                var files = Directory.GetFiles(path + selserver, "*.jar");
                serverfile.Items.Clear();
                versel.Items.Clear();
                foreach (string file in files)
                {
                    serverfile.Items.Add(file.Replace(path + selserver + "\\", ""));
                    versel.Items.Add(file.Replace(path + selserver + "\\", ""));
                }
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        public void GUI_Load(object sender, EventArgs e)
        {
            try
            {
                //今あるフォルダの表示
                serverfolder.Items.Clear();
                string path = Directory.GetCurrentDirectory() + "\\server";
                string[] arr = Directory.GetDirectories(path);
                foreach (var str in arr)
                {
                    string dir = str.Replace(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\server\\", "");
                    serverfolder.Items.Add(dir);
                }
                //サーバーファイルのあるフォルダの取得とか
                serversel.Items.Clear();
                path = Directory.GetCurrentDirectory() + "\\jar";
                var folders = Directory.GetDirectories(path);
                foreach (string file in folders)
                {
                    serversel.Items.Add(file.Replace(path + "\\", ""));
                }
                string mainpath = Directory.GetCurrentDirectory() + "\\";
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //サーバー作成
                if (String.IsNullOrEmpty(foldername.Text))
                {
                    throw new Exception("フォルダ名が指定されていません");
                }
                //現在のパスを保存
                string pastpath = Directory.GetCurrentDirectory();
                //移動予定のパスを保存
                string path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\server\\" + foldername.Text;
                //フォルダ作成
                Directory.CreateDirectory(path);
                //jarとbatをコピー
                File.Copy(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\jar\\" + serversel.Text + "\\" + versel.Text, path + "\\" + "server.jar");
                File.Copy(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\bat\\" + "start.bat", path + "\\" + "start.bat");
                //batファイルを起動する
                ProcessStartInfo pInfo = new ProcessStartInfo();
                pInfo.FileName = path + "\\" + "start.bat";
                Directory.SetCurrentDirectory(path);
                Process proc = Process.Start(pInfo);
                File.Copy(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\eula\\" + "eula.txt", path + "\\" + "eula.txt");
                Directory.SetCurrentDirectory(pastpath);
                proc.WaitForExit();
                //今あるフォルダの表示
                string path2 = Directory.GetCurrentDirectory() + "\\server";
                serverfolder.Items.Clear();
                string[] arr = Directory.GetDirectories(path2);
                foreach (var str in arr)
                {
                    string dir = str.Replace(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\server\\", "");
                    serverfolder.Items.Add(dir);
                }
            }
            catch (Exception ex)
            {
                try
                {
                    Directory.Delete(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\server\\" + foldername.Text);
                }
                catch { }
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void versel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selver = versel.Text;
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selfol = serverfolder.SelectedItem.ToString();
                Console.WriteLine(selfol);
            }
            catch
            {
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                //サーバー起動
                string pastpath = Directory.GetCurrentDirectory();
                string path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\server\\";
                ProcessStartInfo pInfo = new ProcessStartInfo();
                string selfol = serverfolder.SelectedItem.ToString();
                Directory.SetCurrentDirectory(path + selfol);
                pInfo.FileName = path + selfol + "\\start.bat";
                Process proc = Process.Start(pInfo);
                Directory.SetCurrentDirectory(pastpath);
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            try
            {
                //再読み込み
                reloading();
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("再読み込みしました", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void removefile_Click(object sender, EventArgs e)
        {
            try
            {
                //フォルダの削除
                string selfol = serverfolder.SelectedItem.ToString();
                System.Media.SystemSounds.Exclamation.Play();
                DialogResult result = MessageBox.Show("本当に " + selfol + " のフォルダを削除してもいいですか?", "attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string path = Directory.GetCurrentDirectory() + "\\server\\" + selfol;
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete(path, true);
                        System.Media.SystemSounds.Asterisk.Play();
                        MessageBox.Show("削除しました", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        System.Media.SystemSounds.Asterisk.Play();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        reloading();
                    }
                }
                reloading();
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void openfolder_Click(object sender, EventArgs e)
        {
            try
            {
                //フォルダ開く
                Process.Start(Directory.GetCurrentDirectory() + "\\server\\" + serverfolder.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void openprofiles_Click(object sender, EventArgs e)
        {
            try
            {
                //設定開く
                Process.Start(Directory.GetCurrentDirectory() + "\\server\\" + serverfolder.SelectedItem.ToString() + "\\server.properties");
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void openworld_Click(object sender, EventArgs e)
        {
            try
            {
                //フォルダ開く
                Process.Start(Directory.GetCurrentDirectory() + "\\server\\" + serverfolder.SelectedItem.ToString() + "\\world");
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reloading();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}