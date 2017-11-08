using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using WMPLib;
//using Excel = Microsoft.Office.Interop.Excel;


namespace payphone
{
   
    
    public partial class Payphone : Form
    {
        public Payphone()
        {
            
            InitializeComponent();
            
            btn_Call.Enabled = false;
            btn_Cancel.Enabled = false;
            ATC subForm = new ATC();
            subForm.Owner = this;
            subForm.Show();
            subForm.CallEvent += ATC_CallEvent;



           // sheet.Cells[1, 1].Value = "Поповнення: ";


        }
        WindowsMediaPlayer wmp1 = new WindowsMediaPlayer();
        


        public double balance; //баланс
        public string isFree; //busy
        public string[] sb; // exel balance
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        SpeachCall sForm;
       

        //кнопки таксофона
        #region buttons
        private void btn_0_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "0";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();


        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "1";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();

        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "2";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();

        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "3";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();

        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "9";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();

        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "8";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();

        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "7";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();

        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "6";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();

        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "5";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();

        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            t_NCall.Text = t_NCall.Text + "4";
            wmp1.URL = Environment.CurrentDirectory.ToString() + "\\button.WAV"; ;
            wmp1.settings.volume = 100;
            wmp1.controls.play();

        }
        #endregion //

        private void funcWalletOpen(object sender, EventArgs e)
        {
            Wallet subForm = new Wallet();
            subForm.Owner = this;
            subForm.Show();
            subForm.MyEvent += subform_MyEvent;
        } //открыть Wallet
        void subform_MyEvent(object sender, string e)
        {
            t_Balance.Text = "Ваш баланс: " + e;
            if (Convert.ToInt32(e) > 0)
            {
                btn_Call.Enabled = true;
            }
            balance = Convert.ToInt32(e);
        } //передача даных с Wallet   
        void ATC_CallEvent(object sender, string e)
        {
            isFree = e;
        }    
        private void t_NCall_TextChanged(object sender, EventArgs e)
        {
            if (t_NCall.Text == "911" && balance < 1)
            {
                btn_Call.Enabled = true;
            }
            else if (balance < 1)
            {
                btn_Call.Enabled = false;
            }

        } //отслеживание возможности звонка
        private void btn_Call_Click(object sender, EventArgs e)
        {
            
           
            

            if (isFree != "Busy")
            {
                if (t_NCall.Text == "911")
                {
                    btn_0.Enabled = false;
                    btn_1.Enabled = false;
                    btn_2.Enabled = false;
                    btn_3.Enabled = false;
                    btn_4.Enabled = false;
                    btn_5.Enabled = false;
                    btn_6.Enabled = false;
                    btn_7.Enabled = false;
                    btn_8.Enabled = false;
                    btn_9.Enabled = false;
                    btn_Call.Enabled = false;
                    btn_Cancel.Enabled = true;
                    sForm = new SpeachCall();               
                    sForm.Owner = this;
                    sForm.Show();
                    wmp1.URL = Environment.CurrentDirectory.ToString() + "\\callingbeep.mp3"; ;
                    wmp1.settings.volume = 100;
                    wmp1.controls.play();
                    t_NCall.Text = "Розмова з " + t_NCall.Text;
                    
                }
                else if (t_NCall.Text.Length > 6 && t_NCall.Text.Length < 9)
                {
                    timer.Interval = 1000; //интервал между срабатываниями 1000 миллисекунд
                    timer.Tick += new EventHandler(timer_Tick); //подписываемся на события Tick
                    timer.Start();
                    btn_0.Enabled = false;
                    btn_1.Enabled = false;
                    btn_2.Enabled = false;
                    btn_3.Enabled = false;
                    btn_4.Enabled = false;
                    btn_5.Enabled = false;
                    btn_6.Enabled = false;
                    btn_7.Enabled = false;
                    btn_8.Enabled = false;
                    btn_9.Enabled = false;
                    btn_Call.Enabled = false;
                    btn_Cancel.Enabled = true;
                    wmp1.URL = Environment.CurrentDirectory.ToString() + "\\callingbeep.mp3"; ;
                    wmp1.settings.volume = 100;
                    wmp1.controls.play();
                    t_NCall.Text = "Розмова з " + t_NCall.Text;
                    sForm = new SpeachCall();
                    sForm.Owner = this;
                    sForm.Show();
                } // перевірка на можливість дзвінка
                else
                {
                    btn_0.Enabled = false;
                    btn_1.Enabled = false;
                    btn_2.Enabled = false;
                    btn_3.Enabled = false;
                    btn_4.Enabled = false;
                    btn_5.Enabled = false;
                    btn_6.Enabled = false;
                    btn_7.Enabled = false;
                    btn_8.Enabled = false;
                    btn_9.Enabled = false;
                    btn_Call.Enabled = false;
                    btn_Cancel.Enabled = true;
                    wmp1.URL = Environment.CurrentDirectory.ToString() + "\\wrongnumber.mp3"; ;
                    wmp1.settings.volume = 100;
                    wmp1.controls.play();

                    t_NCall.Text = "Невірний номер, спробуйте ще";
                }
            }
            else
            {
                btn_0.Enabled = false;
                btn_1.Enabled = false;
                btn_2.Enabled = false;
                btn_3.Enabled = false;
                btn_4.Enabled = false;
                btn_5.Enabled = false;
                btn_6.Enabled = false;
                btn_7.Enabled = false;
                btn_8.Enabled = false;
                btn_9.Enabled = false;
                btn_Call.Enabled = false;
                btn_Cancel.Enabled = true;
                wmp1.URL = Environment.CurrentDirectory.ToString() + "\\lineisbusy.mp3"; ;
                wmp1.settings.volume = 100;
                wmp1.controls.play();

                t_NCall.Text = "Абонент не може прийняти дзвінок";
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_0.Enabled = true;
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
            btn_Call.Enabled = true;
            t_NCall.Text = "";
            sForm.Close();    
            timer.Stop();
            wmp1.controls.stop();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (balance > 0)
            {
                balance = balance - 0.5;
                t_Balance.Text = "На вашому рахунку " + balance.ToString();
            }      
            else
            {
                balance = 0;
                t_Balance.Text = "На вашому рахунку " + balance.ToString();
                sForm.Close();
                timer.Stop();              
            }
        
        }//снятие с баланса
        int indexe=1;
      //  Excel.Application excel = new Excel.Application(); //создаем COM-объект Excel

        private void button2_Click(object sender, EventArgs e)
        {
            //excel.SheetsInNewWorkbook = 1;//количество листов в книге
            //excel.Workbooks.Add(Type.Missing); //добавляем книгу
            //Excel.Workbook workbook = excel.Workbooks[1]; //получам ссылку на первую открытую книгу
            //Excel.Worksheet sheet = workbook.Worksheets.get_Item(1);//получаем ссылку на первый лист          
            //sheet.Cells[1, indexe].Value ="Баланс: " + balance;
            //if (t_NCall.Text == "911" || t_NCall.Text.Length > 6 && t_NCall.Text.Length < 9)
            //{
            //    sheet.Cells[2, indexe].Value = "Номер: " + t_NCall.Text;
            //}
            //else { sheet.Cells[2, indexe].Value = "Номер: не существует"; }
            //sheet.Cells[3, indexe].Value = "Занято: " + isFree;
            //indexe=indexe+3;
            //excel.Visible = true; //делаем объект видимым
        }
    }
}
