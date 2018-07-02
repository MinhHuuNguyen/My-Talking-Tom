using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTalkingTom.Manager
{
    class TimeManager
    {
        private static int secondsPassed;
        private static String strMonth, strDay, strYear, strHour, strMinute, strSecond;

        public static int GetTimeSpan(String filePath)
        {
            if (File.Exists(filePath))
            {
                int count = 0;
                String tempStr = FileManager.OpenReadFile(filePath);
                foreach (char item in tempStr)
                {
                    count++;
                    switch(count)
                    {
                        case 1:
                        case 2:
                            {
                                strMonth += item;
                                break;
                            }
                        case 3:
                        case 4:
                            {
                                strDay += item;
                                break;
                            }
                        case 5:
                        case 6:
                            {
                                strYear += item;
                                break;
                            }
                        case 7:
                        case 8:
                            {
                                strHour += item;
                                break;
                            }
                        case 9:
                        case 10:
                            {
                                strMinute += item;
                                break;
                            }
                        case 11:
                        case 12:
                            {
                                strSecond += item;
                                break;
                            }
                    }
                }
                DateTime lastDateTime = new DateTime(2000 + Convert.ToInt32(strYear), Convert.ToInt32(strMonth),
                    Convert.ToInt32(strDay), Convert.ToInt32(strHour),
                    Convert.ToInt32(strMinute), Convert.ToInt32(strSecond));
                DateTime nowDateTime = DateTime.Now;
                TimeSpan timeSpan = nowDateTime.Subtract(lastDateTime);
                secondsPassed = timeSpan.Days * 86400 + timeSpan.Hours * 3600 + timeSpan.Minutes * 60 
                    + timeSpan.Seconds;
            }
            strYear = null;
            strMonth = null;
            strDay = null;
            strHour = null;
            strMinute = null;
            strSecond = null;
        return secondsPassed;
        }
    }
}
