using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Tobii.Interaction;
using Gma.System.MouseKeyHook;

namespace webBrowser
{
    public partial class MainWindow : Form
    {
        bool isKeyboard = false; //Флаг включена ли сейчас экранная клавиатура
        bool isClick = false; //Флаг нажат ли сейчас "клик"
        bool keyCombinationIsPressed = false; //Флаг нажата ли комбинация клавиш

        Thread threadProgressBar; //Поток для прогресс бара
        System.Diagnostics.Process keyboardProc; //Процесс для клавиатуры

        ImageList imageListProgressButton = new ImageList(); //Лист картинок прогресс бара

        //События мыши
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public MainWindow()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.sticker_9; //Установка иконки приложения
            this.Text = "YouBoob"; //Установка названия приложения
            this.WindowState = FormWindowState.Maximized; //Расширить окно до максимума
            string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"; //Ссылка на главную страницу браузера
            //Задать браузеру главную страницу
            browser.Navigate(url);

            //Загрузка картинок прогресс бара
            imageListProgressButton.Images.Add("0", Properties.Resources._0);
            imageListProgressButton.Images.Add("1", Properties.Resources._1);
            imageListProgressButton.Images.Add("2", Properties.Resources._2);
            imageListProgressButton.Images.Add("3", Properties.Resources._3);
            imageListProgressButton.Images.Add("4", Properties.Resources._4);
            imageListProgressButton.Images.Add("5", Properties.Resources._5);
            imageListProgressButton.Images.Add("6", Properties.Resources._6);           
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Pause|Play
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonPausePlay_Click(object sender, EventArgs e)
        {
            //Если произведен клик
            if(isClick)
            {
                //Активировать функцию Паузы(Плей) видео
                browser.Document.InvokeScript("pausePlayVideo");
                isClick = false;
            }
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Next
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            //Если произведен клик
            if (isClick)
            {
                //Активировать функцию перемотки видео
                object[] arg = { "+" };
                browser.Document.InvokeScript("rewindVideo", arg);
                isClick = false;
            }
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Back
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Если произведен клик
            if (isClick)
            {
                //Активировать функцию перемотки видео
                object[] arg = { "-" };
                browser.Document.InvokeScript("rewindVideo", arg);
                isClick = false;
            }
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Plus Volume
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonPlusVolume_Click(object sender, EventArgs e)
        {
            //Если произведен клик
            if (isClick)
            {
                //Активировать функцию изменения звука в видео
                object[] arg = { "+" };
                browser.Document.InvokeScript("changeVolumeInVideo", arg);
                isClick = false;
            }
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Minus Volume
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonMinusVolume_Click(object sender, EventArgs e)
        {
            //Если произведен клик
            if (isClick)
            {
                //Активировать функцию изменения звука в видео
                object[] arg = { "-" };
                browser.Document.InvokeScript("changeVolumeInVideo", arg);
                isClick = false;
            }
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Mute Volume
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonMuteVolume_Click(object sender, EventArgs e)
        {
            if (isClick)
            {
                //Активировать функцию мута звука в видео
                browser.Document.InvokeScript("muteVolumeInVideo");
                isClick = false;
            }
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Plus Rate
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonPlusRate_Click(object sender, EventArgs e)
        {
            //Если произведен клик
            if (isClick)
            {
                //Активировать функцию изменения скорости в видео
                object[] arg = { "+" };
                browser.Document.InvokeScript("changeRateInVideo", arg);
                isClick = false;
            }
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Minus Rate
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonMinusRate_Click(object sender, EventArgs e)
        {
            //Если произведен клик
            if (isClick)
            {
                //Активировать функцию изменения скорости в видео
                object[] arg = { "-" };
                browser.Document.InvokeScript("changeRateInVideo", arg);
                isClick = false;
            }
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Keyboard
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonKeyboard_Click(object sender, EventArgs e)
        {
            //Если произведен клик
            if (isClick)
            {
                //Если клавиатура запущена
                if (isKeyboard)
                {
                    //Если процесс клавиатуры существует, принудительно завершить его
                    if (!keyboardProc.HasExited)
                    {
                        keyboardProc.Kill();
                    }
                    isKeyboard = false;
                }
                else
                {
                    //Запускаем клавиатуру в отдельном потоке
                    keyboardProc = System.Diagnostics.Process.Start(@"C:\Windows\WinSxS\amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.19041.1_none_60ade0eff94c37fc\osk.exe");
                    isKeyboard = true;
                }
                isClick = false;
            }
        }

        /// <summary>
        /// Оброботчик события клика по кнопки Click
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие клика </param>
        private void buttonClickMouse_Click(object sender, EventArgs e)
        {
            //Если произведен клик
            if (isClick)
            {
                //Создать поток клика мыши
                Thread threadClickMouse = new Thread(new ThreadStart(delegate
            {
                Thread.Sleep(2000);
                //Активировать клик
                DoMouseClick();
            }));
                //Запустить поток
                threadClickMouse.Start();
                isClick = false;
            }
        }

        /// <summary>
        /// Производит клик в текущей позиции курсора
        /// </summary>
        public void DoMouseClick()
        {
            //Получить текущую позицию курсора
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            //Произвести клик в заданной позиции
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        /// <summary>
        /// Устанавливает изображения в кнопке
        /// </summary>
        /// <param name="btn"> кнопка </param>
        /// <param name="imgList"> лист изображений </param>
        private void setImageInButton(Button btn, ImageList imgList)
        {
            ImageList cpyImgList = imgList;
            //Сменять по очереди изображения в кнопке
            for (int i = 0; i < 7; ++i)
            {
                Thread.Sleep(200);
                this.Invoke(new ThreadStart(delegate
                {
                    btn.BackgroundImage = cpyImgList.Images[i];
                }));
            }
        }

        /// <summary>
        /// Оброботчик события вхождения курсора в область кнопки
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие вхождения курсора </param>
        private void buttons_MouseEnter(object sender, EventArgs e)
        {
            //Если существует другой поток прогресс бара, принудительно завершить его
            if (threadProgressBar != null && threadProgressBar.ThreadState == ThreadState.Running)
                threadProgressBar.Abort();
            //Создать поток прогресс бара
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                Thread.Sleep(300);
                //Запустить цикл прогресс бара
                setImageInButton(((Button)sender), imageListProgressButton);
                //Осуществить клик по кнопке
                Invoke((MethodInvoker)delegate
                {
                    isClick = true;
                    ((Button)sender).PerformClick();
                });
                Thread.Sleep(200);
                //Установить стартовую картинку в кнопке
                ((Button)sender).BackgroundImage = imageListProgressButton.Images[0];
            }));
            //Запустить поток
            threadProgressBar.Start();
        }

        /// <summary>
        /// Оброботчик события покидания курсора из области кнопки
        /// </summary>
        /// <param name="sender"> кнопка </param>
        /// <param name="e"> событие покидания курсора </param>
        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            //Завершить принудительно процесс прогресс бара
            threadProgressBar.Abort();
            //Установить стартовую картинку в кнопке
            ((Button)sender).BackgroundImage = imageListProgressButton.Images[0];
        }

        /// <summary>
        /// Оброботчик события загрузки страницы в браузере
        /// </summary>
        /// <param name="sender"> страница в браузере </param>
        /// <param name="e"> событие загрузки страницы </param>
        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Загрузить Js из файла на страницу
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", Properties.Resources.scriptJs);
            head.AppendChild(s);
        }

        /// <summary>
        /// Оброботчик события нажатия комбинации клавиш
        /// </summary>
        /// <param name="sender"> отправитель сигнала </param>
        /// <param name="e"> событие нажатия клавиш </param>
        private void browser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Если прожата комбинация клавиш
            if (keyCombinationIsPressed && e.Control && e.KeyCode == Keys.D)
            {
                //Включить(Выключить) движения мыши с помощью eye Tracker
                EyeController.toggleGazeMouse(null, null);
            }
            //Изменить флаг нажатия комбинации клавиш
            keyCombinationIsPressed = !keyCombinationIsPressed;
        }
    }
}
