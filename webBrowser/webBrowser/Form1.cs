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

namespace webBrowser
{
    public partial class MainWindow : Form
    {
        bool isPause = false;
        bool isKeyboard = false;

        Thread threadProgressBar;
        System.Diagnostics.Process keyboardProc;

        ImageList imageListProgressPlayPause = new ImageList();
        ImageList imageListProgressNext = new ImageList();
        ImageList imageListProgressBack = new ImageList();
        ImageList imageListProgressPlusVolume = new ImageList();
        ImageList imageListProgressMinusVolume = new ImageList();
        ImageList imageListProgressMuteVolume = new ImageList();
        ImageList imageListProgressPlusRate = new ImageList();
        ImageList imageListProgressMinusRate = new ImageList();
        ImageList imageListProgressKeyboard = new ImageList();

        public MainWindow()
        {
            InitializeComponent();
            string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            browser.Navigate(url);

            imageListProgressPlayPause.Images.Add("0", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\0.jpg"));
            imageListProgressPlayPause.Images.Add("1", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\1.jpg"));
            imageListProgressPlayPause.Images.Add("2", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\2.jpg"));
            imageListProgressPlayPause.Images.Add("3", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\3.jpg"));
            imageListProgressPlayPause.Images.Add("4", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\4.jpg"));
            imageListProgressPlayPause.Images.Add("5", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\5.jpg"));
            imageListProgressPlayPause.Images.Add("6", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\6.jpg"));

            imageListProgressNext.Images.Add("0", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\0.jpg"));
            imageListProgressNext.Images.Add("1", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\1.jpg"));
            imageListProgressNext.Images.Add("2", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\2.jpg"));
            imageListProgressNext.Images.Add("3", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\3.jpg"));
            imageListProgressNext.Images.Add("4", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\4.jpg"));
            imageListProgressNext.Images.Add("5", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\5.jpg"));
            imageListProgressNext.Images.Add("6", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\6.jpg"));

            imageListProgressBack.Images.Add("0", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\0.jpg"));
            imageListProgressBack.Images.Add("1", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\1.jpg"));
            imageListProgressBack.Images.Add("2", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\2.jpg"));
            imageListProgressBack.Images.Add("3", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\3.jpg"));
            imageListProgressBack.Images.Add("4", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\4.jpg"));
            imageListProgressBack.Images.Add("5", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\5.jpg"));
            imageListProgressBack.Images.Add("6", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\6.jpg"));

            imageListProgressPlusVolume.Images.Add("0", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\0.jpg"));
            imageListProgressPlusVolume.Images.Add("1", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\1.jpg"));
            imageListProgressPlusVolume.Images.Add("2", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\2.jpg"));
            imageListProgressPlusVolume.Images.Add("3", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\3.jpg"));
            imageListProgressPlusVolume.Images.Add("4", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\4.jpg"));
            imageListProgressPlusVolume.Images.Add("5", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\5.jpg"));
            imageListProgressPlusVolume.Images.Add("6", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\6.jpg"));

            imageListProgressMinusVolume.Images.Add("0", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\0.jpg"));
            imageListProgressMinusVolume.Images.Add("1", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\1.jpg"));
            imageListProgressMinusVolume.Images.Add("2", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\2.jpg"));
            imageListProgressMinusVolume.Images.Add("3", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\3.jpg"));
            imageListProgressMinusVolume.Images.Add("4", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\4.jpg"));
            imageListProgressMinusVolume.Images.Add("5", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\5.jpg"));
            imageListProgressMinusVolume.Images.Add("6", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\6.jpg"));

            imageListProgressMuteVolume.Images.Add("0", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\0.jpg"));
            imageListProgressMuteVolume.Images.Add("1", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\1.jpg"));
            imageListProgressMuteVolume.Images.Add("2", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\2.jpg"));
            imageListProgressMuteVolume.Images.Add("3", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\3.jpg"));
            imageListProgressMuteVolume.Images.Add("4", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\4.jpg"));
            imageListProgressMuteVolume.Images.Add("5", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\5.jpg"));
            imageListProgressMuteVolume.Images.Add("6", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\6.jpg"));

            imageListProgressPlusRate.Images.Add("0", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\0.jpg"));
            imageListProgressPlusRate.Images.Add("1", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\1.jpg"));
            imageListProgressPlusRate.Images.Add("2", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\2.jpg"));
            imageListProgressPlusRate.Images.Add("3", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\3.jpg"));
            imageListProgressPlusRate.Images.Add("4", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\4.jpg"));
            imageListProgressPlusRate.Images.Add("5", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\5.jpg"));
            imageListProgressPlusRate.Images.Add("6", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\6.jpg"));

            imageListProgressMinusRate.Images.Add("0", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\0.jpg"));
            imageListProgressMinusRate.Images.Add("1", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\1.jpg"));
            imageListProgressMinusRate.Images.Add("2", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\2.jpg"));
            imageListProgressMinusRate.Images.Add("3", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\3.jpg"));
            imageListProgressMinusRate.Images.Add("4", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\4.jpg"));
            imageListProgressMinusRate.Images.Add("5", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\5.jpg"));
            imageListProgressMinusRate.Images.Add("6", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\6.jpg"));

            imageListProgressKeyboard.Images.Add("0", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\0.jpg"));
            imageListProgressKeyboard.Images.Add("1", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\1.jpg"));
            imageListProgressKeyboard.Images.Add("2", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\2.jpg"));
            imageListProgressKeyboard.Images.Add("3", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\3.jpg"));
            imageListProgressKeyboard.Images.Add("4", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\4.jpg"));
            imageListProgressKeyboard.Images.Add("5", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\5.jpg"));
            imageListProgressKeyboard.Images.Add("6", Image.FromFile("C:\\Users\\OEM\\Desktop\\progress\\6.jpg"));
        }

        private void buttonPausePlay_Click(object sender, EventArgs e)
        {
            if (isPause)
            {
                HtmlDocument doc = browser.Document;
                HtmlElement head = doc.GetElementsByTagName("head")[0];
                HtmlElement s = doc.CreateElement("script");
                s.SetAttribute("text", "function playVideo() { document.getElementsByClassName('video-stream')[0].play(); }");
                head.AppendChild(s);
                browser.Document.InvokeScript("playVideo");
                isPause = false;
            }
            else
            {
                HtmlDocument doc = browser.Document;
                HtmlElement head = doc.GetElementsByTagName("head")[0];
                HtmlElement s = doc.CreateElement("script");
                s.SetAttribute("text", "function pauseVideo() { document.getElementsByClassName('video-stream')[0].pause(); }");
                head.AppendChild(s);
                browser.Document.InvokeScript("pauseVideo");
                isPause = true;
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", "function nextInVideo() { document.getElementsByClassName('video-stream')[0].currentTime += 5; }");
            head.AppendChild(s);
            browser.Document.InvokeScript("nextInVideo");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", "function backInVideo() { document.getElementsByClassName('video-stream')[0].currentTime -= 5; }");
            head.AppendChild(s);
            browser.Document.InvokeScript("backInVideo");
        }

        private void buttonPlusVolume_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text",
                "    function changeVolumeInVideo(change) {" +
                "    var currentVolume = document.getElementsByClassName('video-stream')[0].volume;" +
                "    if(change == '+') {" +
                "        if(currentVolume < 0.99) {" +
                "            document.getElementsByClassName('video-stream')[0].volume += 0.1;" +
                "        }" +
                "        else {" +
                "            document.getElementsByClassName('video-stream')[0].volume = 1;" +
                "        }" +
                "    }" +
                "    else {" +
                "        if(currentVolume >= 0.1) {" +
                "            document.getElementsByClassName('video-stream')[0].volume -= 0.1;" +
                "        }" +
                "        else {" +
                "            document.getElementsByClassName('video-stream')[0].volume = 0;" +
                "        }" +
                "    } }");
            head.AppendChild(s);
            object[] arg = { "+" };
            browser.Document.InvokeScript("changeVolumeInVideo", arg);
        }

        private void buttonMinusVolume_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text",
                "    function changeVolumeInVideo(change) {" +
                "    var currentVolume = document.getElementsByClassName('video-stream')[0].volume;" +
                "    if(change == '+') {" +
                "        if(currentVolume < 0.99) {" +
                "            document.getElementsByClassName('video-stream')[0].volume += 0.1;" +
                "        }" +
                "        else {" +
                "            document.getElementsByClassName('video-stream')[0].volume = 1;" +
                "        }" +
                "    }" +
                "    else {" +
                "        if(currentVolume >= 0.1) {" +
                "            document.getElementsByClassName('video-stream')[0].volume -= 0.1;" +
                "        }" +
                "        else {" +
                "            document.getElementsByClassName('video-stream')[0].volume = 0;" +
                "        }" +
                "    } }");
            head.AppendChild(s);
            object[] arg = { "-" };
            browser.Document.InvokeScript("changeVolumeInVideo", arg);
        }

        private void buttonMuteVolume_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text",
                "function muteVolumeInVideo() {" +
                "    if(document.getElementsByClassName('video-stream')[0].muted) {" +
                "        document.getElementsByClassName('video-stream')[0].muted = false;" +
                "    }" +
                "    else {" +
                "        document.getElementsByClassName('video-stream')[0].muted = true;" +
                "    } }");
            head.AppendChild(s);
            browser.Document.InvokeScript("muteVolumeInVideo");
        }

        private void buttonPlusRate_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text",
                "function changeRateInVideo(change) {" +
                "    var rate = document.getElementsByClassName('video-stream')[0].playbackRate;" +
                "    if(change == '+') {" +
                "        if(rate < 2) {" +
                "            document.getElementsByClassName('video-stream')[0].playbackRate += 0.25;" +
                "        }" +
                "    }" +
                "    else {" +
                "        if(rate > 0.25) {" +
                "            document.getElementsByClassName('video-stream')[0].playbackRate -= 0.25;" +
                "        }" +
                "    } }");
            head.AppendChild(s);
            object[] arg = { "+" };
            browser.Document.InvokeScript("changeRateInVideo", arg);
        }

        private void buttonMinusRate_Click(object sender, EventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", "function changeRateInVideo(change) {" +
                "    var rate = document.getElementsByClassName('video-stream')[0].playbackRate;" +
                "    if(change == '+') {" +
                "        if(rate < 2) {" +
                "            document.getElementsByClassName('video-stream')[0].playbackRate += 0.25;" +
                "        }" +
                "    }" +
                "    else {" +
                "        if(rate > 0.25) {" +
                "            document.getElementsByClassName('video-stream')[0].playbackRate -= 0.25;" +
                "        }" +
                "    } }");
            head.AppendChild(s);
            object[] arg = { "-" };
            browser.Document.InvokeScript("changeRateInVideo", arg);
        }

        private void buttonKeyboard_Click(object sender, EventArgs e)
        {
            //запускаем клавиатуру в отдельном потоке
            if(isKeyboard)
            {
                if(!keyboardProc.HasExited)
                {
                    keyboardProc.Kill();
                }                
                isKeyboard = false;
            }
            else
            {
                keyboardProc = System.Diagnostics.Process.Start("osk.exe");
                isKeyboard = true;
            }
            
        }

        private void buttonPausePlay_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressPlayPause.ImageSize = buttonPausePlay.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonPausePlay.BackgroundImage = imageListProgressPlayPause.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonPausePlay_Click(null, null);
                });
                Thread.Sleep(200);
                buttonPausePlay.BackgroundImage = imageListProgressPlayPause.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonPausePlay_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonPausePlay.BackgroundImage = imageListProgressPlayPause.Images[0];
        }

        private void buttonNext_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressNext.ImageSize = buttonNext.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        //System.Console.WriteLine(imageListProgress.Images.IndexOfKey("1"));
                        buttonNext.BackgroundImage = imageListProgressNext.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonNext_Click(null, null);
                });
                Thread.Sleep(200);
                buttonNext.BackgroundImage = imageListProgressNext.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonNext.BackgroundImage = imageListProgressNext.Images[0];
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressBack.ImageSize = buttonBack.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonBack.BackgroundImage = imageListProgressBack.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonBack_Click(null, null);
                });
                Thread.Sleep(200);
                buttonBack.BackgroundImage = imageListProgressBack.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonBack.BackgroundImage = imageListProgressBack.Images[0];
        }

        private void buttonPlusVolume_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressPlusVolume.ImageSize = buttonPlusVolume.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonPlusVolume.BackgroundImage = imageListProgressPlusVolume.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonPlusVolume_Click(null, null);
                });
                Thread.Sleep(200);
                buttonPlusVolume.BackgroundImage = imageListProgressPlusVolume.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonPlusVolume_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonPlusVolume.BackgroundImage = imageListProgressPlusVolume.Images[0];
        }

        private void buttonMinusVolume_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressMinusVolume.ImageSize = buttonMinusVolume.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonMinusVolume.BackgroundImage = imageListProgressMinusVolume.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonMinusVolume_Click(null, null);
                });
                Thread.Sleep(200);
                buttonMinusVolume.BackgroundImage = imageListProgressMinusVolume.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonMinusVolume_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonMinusVolume.BackgroundImage = imageListProgressMinusVolume.Images[0];
        }

        private void buttonMuteVolume_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressMuteVolume.ImageSize = buttonMuteVolume.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonMuteVolume.BackgroundImage = imageListProgressMuteVolume.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonMuteVolume_Click(null, null);
                });
                Thread.Sleep(200);
                buttonMuteVolume.BackgroundImage = imageListProgressMuteVolume.Images[0];
            }));

            threadProgressBar.Start();
        }

        private void buttonMuteVolume_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonMuteVolume.BackgroundImage = imageListProgressMuteVolume.Images[0];
        }

        private void buttonPlusRate_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressPlusRate.ImageSize = buttonPlusRate.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonPlusRate.BackgroundImage = imageListProgressPlusRate.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonPlusRate_Click(null, null);
                });
                Thread.Sleep(200);
                buttonPlusRate.BackgroundImage = imageListProgressPlusRate.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonPlusRate_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonPlusRate.BackgroundImage = imageListProgressPlusRate.Images[0];
        }

        private void buttonMinusRate_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressMinusRate.ImageSize = buttonMinusRate.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonMinusRate.BackgroundImage = imageListProgressMinusRate.Images[i];
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonMinusRate_Click(null, null);
                });
                Thread.Sleep(200);
                buttonMinusRate.BackgroundImage = imageListProgressMinusRate.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonMinusRate_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonMinusRate.BackgroundImage = imageListProgressMinusRate.Images[0];
        }

        private void buttonKeyboard_MouseEnter(object sender, EventArgs e)
        {
            imageListProgressKeyboard.ImageSize = buttonKeyboard.Size;
            threadProgressBar = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < 7; ++i)
                {
                    Thread.Sleep(100);
                    this.Invoke(new ThreadStart(delegate
                    {
                        buttonKeyboard.BackgroundImage = imageListProgressKeyboard.Images[i];   
                    }));
                }
                Invoke((MethodInvoker)delegate
                {
                    buttonKeyboard_Click(null, null);
                });
                Thread.Sleep(200);
                buttonKeyboard.BackgroundImage = imageListProgressKeyboard.Images[0];
            }));
            threadProgressBar.Start();
        }

        private void buttonKeyboard_MouseLeave(object sender, EventArgs e)
        {
            threadProgressBar.Abort();
            buttonKeyboard.BackgroundImage = imageListProgressKeyboard.Images[0];
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument doc = browser.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", 
                "var coord = {x: window.innerWidth / 2, y: window.innerHeight / 2};" +
                "var SCROLL_AMOUNT = 10;" +
                "var SCROLL_THRESHOLD = 50;" +
                "function getPosition(e) {" +
                "   var x = y = 0;" +
                "   if (!e) {" +
                "      var e = window.event;" +
                "   }" +
                "   if (e.pageX || e.pageY) {" +
                "       x = e.pageX;" +
                "       y = e.pageY;" +
                "   }" +
                "   else if (e.clientX || e.clientY) {" +
                "       x = e.clientX + document.body.scrollLeft + document.documentElement.scrollLeft;" +
                "       y = e.clientY + document.body.scrollTop + document.documentElement.scrollTop;" +
                "   }" +
                "   return { x: x, y: y };" +
                "   }" +
                "function scrollPage() {" +
                "   var pageTop = window.pageYOffset;" +
                "   if (coord.y >= pageTop + window.innerHeight - SCROLL_THRESHOLD) {" +
                "       window.scrollBy(0, SCROLL_AMOUNT);" +
                "       coord.y += SCROLL_AMOUNT;" +
                "   }" +
                "   else if (coord.y <= pageTop + SCROLL_THRESHOLD) {" +
                "       window.scrollBy(0, -SCROLL_AMOUNT);" +
                "       coord.y -= SCROLL_AMOUNT;" +
                "   } " +
                "}" +
                "addEventListener('mousemove', function(e) {" +
                "   coord = getPosition(e);" +
                "}, true);" +
                "setInterval(scrollPage, 50);");
            head.AppendChild(s);
        }
    }
}
