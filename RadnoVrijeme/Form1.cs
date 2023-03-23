using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadnoVrijeme
{
    public partial class Form1 : Form
    {
        
        List<DateTime> holidays = new List<DateTime>();
        List<DateTime> vacations = new List<DateTime>();
        List<DateTime> trips = new List<DateTime>();

        int year;
        int month;
        DateTime firstDay;
        DateTime lastDay;

        void InitHolidays()
        {
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture("hr-HR");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            
            holidays.Add(DateTime.Parse("26.12.2022."));
            holidays.Add(DateTime.Parse("06.01.2023."));
            holidays.Add(DateTime.Parse("10.04.2023."));
            holidays.Add(DateTime.Parse("01.05.2023."));
            holidays.Add(DateTime.Parse("30.05.2023."));
            holidays.Add(DateTime.Parse("08.06.2023."));
            holidays.Add(DateTime.Parse("22.06.2023."));
            holidays.Add(DateTime.Parse("05.08.2023."));
            holidays.Add(DateTime.Parse("15.08.2023."));
            holidays.Add(DateTime.Parse("01.11.2023."));
            holidays.Add(DateTime.Parse("18.11.2023."));
            holidays.Add(DateTime.Parse("25.12.2023."));
            holidays.Add(DateTime.Parse("26.12.2023."));

        }

        public Form1()
        {
            InitializeComponent();
            InitHolidays();
            CurrentDatePicker.Value = DateTime.Now.Date;
            StartDatePicker.Value = DateTime.Now.Date;
            EndDatePicker.Value = DateTime.Now.Date;
            EmployeeComboBox.Text = EmployeeComboBox.Items[0].ToString();
        }

        private bool IsHolliday(DateTime date)
        {
            return holidays.Contains(date.Date);
        }

        private bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        private bool IsVacation(DateTime date)
        {
            return vacations.Contains(date.Date);
        }

        private bool IsTrip(DateTime date)
        {
            return trips.Contains(date.Date);
        }


        private String WorkHoursPerDays()
        {
            int dayInMounth = 1;
            int hollidaysCount = 0;
            int vacationDaysCount = 0;
            int tripDaysCount = 0;
            int sumall = 0;

            String output = "";
            for (DateTime date = firstDay; date.Date < lastDay; date = date.AddDays(1))
            {
                output += "<tr>";
                // day in a month
                output += "<td style=\"height:3px\">" + dayInMounth + "</td>";
                // working time
                if (!IsWeekend(date) && !IsHolliday(date) && !IsVacation(date) || IsTrip(date))
                {
                    output += "<td>" + "09:00-17:00" + "</td>";                                        
                    
                } else
                {
                    output += "<td></td>";                    
                }
                // work hours
                if (!IsWeekend(date) || IsTrip(date))
                {
                    output += "<td>8</td>";
                    sumall++;
                } else
                {
                    output += "<td></td>";
                }

                // overwork
                    output += "<td></td>";
                // sunday
                output += "<td></td>";
                // hollidays
                if (IsHolliday(date) && !IsWeekend(date))
                {
                    output += "<td>8</td>";
                    hollidaysCount++;
                } else
                {
                    output += "<td></td>";
                }
                // night work
                output += "<td></td>";
                // sick leave
                output += "<td></td>";
                // vacation
                if (IsVacation(date) && !IsWeekend(date))
                {
                    output += "<td>8</td>";
                    vacationDaysCount++;
                }
                else
                {
                    output += "<td></td>";
                }
                // paid leave
                output += "<td></td>";
                // non paid leave
                output += "<td></td>";
                // trip
                if (IsTrip(date))
                {
                    output += "<td>8</td>";
                    tripDaysCount++;
                }
                else
                {
                    output += "<td></td>";
                }
                // terrain work
                output += "<td></td>";
                // maternity leave
                output += "<td></td>";

                output += "</tr>";
                dayInMounth++;
            }

            // sum of all hours
            output += "<tr>";
            output += "<td colspan=\"2\"><b>Ukupno sati:</b></ td>";
            output += "<td><b>" + sumall*8 + "</b></td>";
            output += "<td></td>";
            output += "<td></td>";
            if (hollidaysCount > 0)
            {
                output += "<td><b>" + hollidaysCount * 8 + "</b></td>";
            } else
            {
                output += "<td></td>";
            }
            
            output += "<td></td>";
            output += "<td></td>";
            if (vacationDaysCount > 0)
            {
                output += "<td><b>" + vacationDaysCount * 8 + "</b></td>";
            } else
            {
                output += "<td></td>";
            }
            
            output += "<td></td>";
            output += "<td></td>";
            if (tripDaysCount > 0)
            {
                output += "<td><b>" + tripDaysCount * 8 + "</b></td>";
            } else
            {
                output += "<td></td>";
            }
            
            output += "<td></td>";
            output += "<td></td>";

            output += "</tr>";

            return output;
        }

        private String SetMonth(String inpLine)
        {
            String monthStr = "" + month + "." + year + ".";
            if (monthStr.Length < 8)
            {
                monthStr = "0" + monthStr;
            }
            return inpLine.Replace("REPLACEMONTH", monthStr);
        }

        private String SetEmployee(String inpLine)
        {
            String employee = EmployeeComboBox.Text;
            return inpLine.Replace("REPLACEEMPLOYEE", employee);
        }


        private void CreateReport_Click(object sender, EventArgs e)
        {
            // set values depending on a selected date
            year = CurrentDatePicker.Value.Year;
            month = CurrentDatePicker.Value.Month;
            firstDay = new DateTime(year, month, 1);
            int year2 = month < 12 ? year : year + 1;
            int month2 = month < 12 ? month + 1 : 1;
            lastDay = new DateTime(year2, month2, 1);

            // open streams
            System.IO.StreamReader reader = new System.IO.StreamReader("..\\..\\Template.html");
            System.IO.StreamWriter writer = new System.IO.StreamWriter("c:\\Temp\\" + month + "." + year + ". - " + EmployeeComboBox.Text +  ".html");
           
            // replace input lines with calculated values
            while (!reader.EndOfStream)
            {
                String inpLine = reader.ReadLine();
                if (inpLine.Contains("REPLACEWORKHOURS"))
                {
                    writer.WriteLine(WorkHoursPerDays());
                }   
                else if (inpLine.Contains("REPLACEMONTH"))
                {
                    writer.WriteLine(SetMonth(inpLine));
                }
                else if (inpLine.Contains("REPLACEEMPLOYEE"))
                {
                    writer.WriteLine(SetEmployee(inpLine));
                }
                else
                {
                    writer.WriteLine(inpLine);
                }
            }

            // close streams
            reader.Close();
            writer.Close();
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDatePicker.Value = StartDatePicker.Value;
        }

        private void AddVacationButton_Click(object sender, EventArgs e)
        {
            DateTime firstDay = StartDatePicker.Value.Date;
            DateTime lastDay = EndDatePicker.Value.Date;
            for (DateTime date = firstDay; date.Date <= lastDay; date = date.AddDays(1))
            {
                if (!IsWeekend(date) && !IsHolliday(date))
                {
                    vacations.Add(date);
                    VacationListBox.Items.Add(date.ToShortDateString());
                }                
            }
        }

        private void AddTripButton_Click(object sender, EventArgs e)
        {
            DateTime firstDay = StartDatePicker.Value.Date;
            DateTime lastDay = EndDatePicker.Value.Date;
            for (DateTime date = firstDay; date.Date <= lastDay; date = date.AddDays(1))
            {
                trips.Add(date);
                TripListBox.Items.Add(date.ToShortDateString());
            }
        }

        private void EmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
