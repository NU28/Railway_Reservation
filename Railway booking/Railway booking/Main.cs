using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Railway_booking
{
    class Reservation
    {
        SqlConnection con;//PUT YOUR SERVER NAME IN "Server=.\\SQLSERVER" with double backslash
        SqlCommand cmd;
        SqlDataReader rd;
        string sq = "Server=;initial catalog=Railway;integrated security=sspi";
        int pin, s_no, age, tno, bfare, rcharge, cv, n, r, pass, nsc, ng, o, sn, pid;
        double stax, tfare, sc, tsc, tf;
        long pnr, tid;
        Int64 mobile, aadhar, phone, cno, wmobile;
        string userid, passkey, cpassword, passwords, sans, fname, mname, lname, gender, ms, dob, occ, email, nationality, full_add, tname;
        string country, states, city, name, berth_prefer, sources, destination, classe, quota, jdate, cname, cedate, coachno;
        void signup()
        {
            con = new SqlConnection(sq);
            con.Open();
            Console.Clear();
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n");
            Console.WriteLine("\n\n\t\t\t\tSIGN UP");
            Console.WriteLine("\t\t*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");
            Console.Write("\nUser ID : -\t");
            userid = Console.ReadLine();
            cmd = new SqlCommand("select userid from reg where userid ='" + userid + "'", con);
            rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                Console.WriteLine("\nUser id already Exist.");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\nPassword : -\t");
                passwords = Console.ReadLine();
                Console.Write("\nConfirm Password : -\t");
                cpassword = Console.ReadLine();
                if (passwords == cpassword)
                {
                    Console.Write("\nSecurity Questions : - ");
                    Console.WriteLine(" 1) What is your pet name ?");
                    Console.WriteLine("\t\t2) What is your nick name ?");
                    Console.WriteLine("\t\t3) What is your Favourite Book ?");
                    Console.WriteLine("\t\t4) What is your Favourite Actor ?");
                    Console.WriteLine("\t\t5) What is your Favourite Color ?");
                    Console.Write("\n\t\tEnter any Security Question from above :- ");
                    int q = int.Parse(Console.ReadLine());
                    switch (q)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n");
                            Console.WriteLine("\n\n\t\t\t\tSIGN UP");
                            Console.WriteLine("\t\t*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");
                            Console.WriteLine("\nUser ID : -\t" + userid);
                            Console.WriteLine("\nPassword : -\t" + passwords);
                            Console.WriteLine("\nConfirm Password : -\t" + cpassword);
                            Console.Write("\nSecurity Questions : - ");
                            Console.WriteLine(" 1) What is your pet name ?");
                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n");
                            Console.WriteLine("\n\n\t\t\t\tSIGN UP");
                            Console.WriteLine("\t\t*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");
                            Console.WriteLine("\nUser ID : -\t" + userid);
                            Console.WriteLine("\nPassword : -\t" + passwords);
                            Console.WriteLine("\nConfirm Password : -\t" + cpassword);
                            Console.Write("\nSecurity Questions : - ");
                            Console.WriteLine(" 2) What is your nick name ?");
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n");
                            Console.WriteLine("\n\n\t\t\t\tSIGN UP");
                            Console.WriteLine("\t\t*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");
                            Console.WriteLine("\nUser ID : -\t" + userid);
                            Console.WriteLine("\nPassword : -\t" + passwords);
                            Console.WriteLine("\nConfirm Password : -\t" + cpassword);
                            Console.Write("\nSecurity Questions : - ");
                            Console.WriteLine(" 3) What is your Favourite Book ?");
                            break;
                        case 4:
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n");
                            Console.WriteLine("\n\n\t\t\t\tSIGN UP");
                            Console.WriteLine("\t\t*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");
                            Console.WriteLine("\nUser ID : -\t" + userid);
                            Console.WriteLine("\nPassword : -\t" + passwords);
                            Console.WriteLine("\nConfirm Password : -\t" + cpassword);
                            Console.Write("\nSecurity Questions : - ");
                            Console.WriteLine(" 4) What is your Favourite Actor ?");
                            break;
                        case 5:
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n");
                            Console.WriteLine("\n\n\t\t\t\tSIGN UP");
                            Console.WriteLine("\t\t*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");
                            Console.WriteLine("\nUser ID : -\t" + userid);
                            Console.WriteLine("\nPassword : -\t" + passwords);
                            Console.WriteLine("\nConfirm Password : -\t" + cpassword);
                            Console.Write("\nSecurity Questions : - ");
                            Console.WriteLine(" 5) What is your Favourite Color ?");
                            break;
                        default:
                            Console.WriteLine("\nSorry ! You Entered Wrong Choice.");
                            break;
                    }
                    Console.Write("\nSecurity Answer : - ");
                    sans = Console.ReadLine();
                    Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\tPersonal Details ");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("\nFirst Name : - ");
                    fname = Console.ReadLine();
                    Console.Write("\nMiddle Name (Optional) : - ");
                    mname = Console.ReadLine();
                    Console.Write("\nLast Name : - ");
                    lname = Console.ReadLine();
                    Console.Write("\nGender : - ");
                    gender = Console.ReadLine();
                    Console.Write("\nMarital Status : - ");
                    ms = Console.ReadLine();
                    Console.Write("\nDate of Birth : - ");
                    dob = Console.ReadLine();
                    Console.Write("\nOccupation : - ");
                    occ = Console.ReadLine();
                    Console.Write("\nAadhaar Card No. : - ");
                    aadhar = Int64.Parse(Console.ReadLine());
                    Console.Write("\nE-mail : - ");
                    email = Console.ReadLine();
                    Console.Write("\nMobile : - ");
                    mobile = Int64.Parse(Console.ReadLine());
                    Console.Write("\nNationality : - ");
                    nationality = Console.ReadLine();
                    Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\tResidential Address ");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("\nFull Address : - ");
                    full_add = Console.ReadLine();
                    Console.Write("\nCountry : - ");
                    country = Console.ReadLine();
                    Console.Write("\nPincode : - ");
                    pin = int.Parse(Console.ReadLine());
                    Console.Write("\nState : - ");
                    states = Console.ReadLine();
                    Console.Write("\nCity/Town : - ");
                    city = Console.ReadLine();
                    Console.Write("\nPhone : - ");
                    phone = Int64.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\nYour Password is incorrect.");
                    Console.ReadKey();
                }
                con.Close();
                con.Open();
                cmd = new SqlCommand("insert into reg values('" + userid + "','" + passwords + "','" + cpassword + "','" + sans + "','" + fname.ToUpper() + "','" + mname.ToUpper() + "','" + lname.ToUpper() + "','" + gender.ToUpper() + "','" + ms.ToUpper() + "','" + dob.ToUpper() + "','" + occ.ToUpper() + "','" + aadhar + "','" + email + "','" + mobile + "','" + nationality.ToUpper() + "','" + full_add.ToUpper() + "','" + country.ToUpper() + "','" + pin + "','" + states.ToUpper() + "','" + city.ToUpper() + "','" + phone + "')", con);
                r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    Console.WriteLine("Thanks! Your Details Registered Successfully.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Sorry! Registration denied.");
                    Console.ReadKey();
                }
                con.Close();                                    
            }
        }
        void login()
        {
            con = new SqlConnection(sq);
            Console.Clear();
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n");
            Console.WriteLine("\n\n\t\t\tLOGIN");
            Console.WriteLine("\t\t*-*-*-*-*-*-*-*-*-*-*-*\n\n");
            Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------------------------");
            con.Open();
            Console.Write("\t\t\t\t\t\tUser ID : - \t\t");
            userid = Console.ReadLine();
            Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------------------------\n");
            Console.Write("\t\t\t\t\t\tPassword : - \t\t");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    passkey += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && passkey.Length > 0)
                {
                    passkey = passkey.Substring(0, (passkey.Length - 1));
                    Console.Write("\b\b");
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine("\n\t\t\t\t\t-----------------------------------------------------------------\n");
            cmd = new SqlCommand("select userid,passwords from reg where userid='" + userid + "'and passwords='" + passkey + "'", con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Console.Clear();
                char c;
                con.Close();
                do
                {
                    Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                    Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                    Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n");
                    Console.WriteLine("1) Services");
                    Console.WriteLine("2) My Transaction");
                    Console.WriteLine("3) My Profile");
                    Console.Write("Enter the Choice from Above ===> ");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            services();
                            break;
                        case 2:
                            My_Transaction();
                            break;
                        case 3:
                            My_Profile();
                            break;
                        default:
                            Console.WriteLine("Your enter Invalid choice.");
                            break;
                    }
                    Console.Write("\n\n\tDo You Want to Continue (Y/N) :- ");
                    c = Console.ReadLine().ElementAt(0);
                    Console.Clear();
                } while (c == 'Y' || c == 'y');

            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tInvalid User ID and Password.");
                Console.WriteLine("\n\n\t\t\t\t\t1) Forgot Password.");
                Console.WriteLine("\n\t\t\t\t\t2) Sign Up.");
                Console.Write("\n\n\t\t\t\t\tEnter The choice : - ");
                int lg = int.Parse(Console.ReadLine());
                switch(lg)
                {
                    case 1:
                        forgot();
                        break;
                    case 2:
                        signup();
                        break;
                }
            }
        }
        void forgot()
        {
            con = new SqlConnection(sq);
            Console.Clear();
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n");
            Console.WriteLine("Enter User Id ======>");
            userid = Console.ReadLine();
            con.Open();
            cmd = new SqlCommand("select userid from reg where userid='" + userid + "'", con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                con.Close();
                con.Open();
                Console.WriteLine("Enter new Password : - ");
                passwords = Console.ReadLine();
                cmd = new SqlCommand("update reg set passwords = '" + passwords + "'where userid = '" + userid + "'", con);
                rd = cmd.ExecuteReader();
                con.Close();
                con.Open();
                Console.WriteLine("Enter Confirm Password : - ");
                cpassword = Console.ReadLine();
                cmd = new SqlCommand("update reg set cpassword = '" + cpassword + "'where userid = '" + userid + "'", con);
                rd = cmd.ExecuteReader();
                Console.WriteLine("Updation Successful.");
                con.Close();
            }
            else
            {
                Console.WriteLine("Invalid User ID.");
            }
        }
        void services()
        {
            con = new SqlConnection(sq);
            con.Open();
            Console.Clear();
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
            Console.Write("\n\nServices : --  ");
            Console.WriteLine("\t\t\t1] Ticket Booking.");
            Console.WriteLine("\t\t\t\t2] Cancel Ticket.");
            Console.WriteLine("\t\t\t\t3] File Ticket Deposit Receipts (TDR).");
            Console.Write("\nEnter the choice from above ===> ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Ticket_booking();
                    break;
                case 2:
                    Cancel_ticket();
                    break;
                case 3:
                    tdr();
                    break;
                default:
                    Console.WriteLine("You Enter Wrong Choice");
                    break;
            }
            con.Close();
        }
        void Ticket_booking()
        {
            con = new SqlConnection(sq);
            Console.Clear();
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
            Console.Write("\nTicket Booking : -- ");
            Console.WriteLine("1] Quick Ticket Booking.");
            Console.WriteLine("\t\t2] Tatkal Ticket Booking.");
            Console.Write("\nEnter the choice from above ===> ");
            o = int.Parse(Console.ReadLine());
            switch (o)
            {
                case 1:
                    Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Journey Details");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("From Station : - ");
                    sources = Console.ReadLine();
                    Console.Write("To Station : - ");
                    destination = Console.ReadLine();
                    if(sources=="New Delhi"&&destination=="Agra Cantt"||sources=="Agra Cantt" && destination=="New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoAC", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString()+"\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoAC where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if(rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - "+sources);
                            Console.WriteLine("To Station : - "+destination);
                            Console.WriteLine("Train No. : - "+tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Mathura" || sources == "Mathura" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoMH", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoMH where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Mumbai Central" || sources == "Mumbai Central" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoMB", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoMB where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Chennai Central" || sources == "Chennai Central" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoCH", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoCH where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Kolkata" || sources == "Kolkata" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoKL", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoKL where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Bhubaneswar" || sources == "Bhubaneswar" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoBH", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoBH where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Jammu Tawi" || sources == "Jammu Tawi" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoJT", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoJT where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else
                    {
                        Console.WriteLine("On This route train is not available.");
                        Console.ReadKey();
                        Console.Clear();
                        Ticket_booking();
                    }
                    Console.Write("Journey Date : - ");
                    jdate = Console.ReadLine();
                    Console.Write("Class : - ");
                    classe = Console.ReadLine();
                    Console.Write("Quota : - ");
                    quota = Console.ReadLine();
                    passenger_detail();
                    break;
                case 2:
                    Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Journey Details");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("From Station : - ");
                    sources = Console.ReadLine();
                    Console.Write("To Station : - ");
                    destination = Console.ReadLine();
                    if (sources == "New Delhi" && destination == "Agra Cantt" || sources == "Agra Cantt" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoAC", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoAC where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Mathura" || sources == "Mathura" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoMH", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoMH where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Mumbai Central" || sources == "Mumbai Central" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoMB", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoMB where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Chennai Central" || sources == "Chennai Central" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoCH", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoCH where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Kolkata" || sources == "Kolkata" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoKL", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoKL where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Bhubaneswar" || sources == "Bhubaneswar" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoBH", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoBH where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else if (sources == "New Delhi" && destination == "Jammu Tawi" || sources == "Jammu Tawi" && destination == "New Delhi")
                    {
                        con.Open();
                        cmd = new SqlCommand("select * from NDtoJT", con);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\n");
                        }
                        con.Close();
                        con.Open();
                        Console.WriteLine("Train No. : - ");
                        tno = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("select * from NDtoJT where train_no='" + tno + "'", con);
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Console.Clear();
                            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Journey Details");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("From Station : - " + sources);
                            Console.WriteLine("To Station : - " + destination);
                            Console.WriteLine("Train No. : - " + tno);
                            tname = rd["train"].ToString();
                            Console.WriteLine("Train Name : - " + tname);
                        }
                        con.Close();
                    }
                    else
                    {
                        Console.WriteLine("On This route train is not available.");
                        Console.ReadKey();
                        Console.Clear();
                        Ticket_booking();
                    }
                    Console.Write("Journey Date : - ");
                    jdate = Console.ReadLine();
                    Console.Write("Class : - ");
                    classe = Console.ReadLine();
                    quota = "Tatkal";
                    Console.WriteLine("Quota : - " + quota);
                    passenger_detail();
                    break;
            }
            
        }
        static Random s = new Random();
        static Random p = new Random();
        void passenger_detail()
        {
            con = new SqlConnection(sq);
            con.Open();
            Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Passenger Details");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.Write("Enter The No. of Passengers : -- ");
            pass = int.Parse(Console.ReadLine());
            if (pass == 0)
            {
                Console.WriteLine("You not Entered No. of Passengers. Please Try Again.");
                Console.ReadKey();
                Console.Clear();
                Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
                Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
                Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                Console.Write("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Journey Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Train No : - " + tno);
                Console.WriteLine("Train Name : - " + tname);
                Console.WriteLine("From Station : - " + sources);
                Console.WriteLine("To Station : - " + destination);
                Console.WriteLine("Journey Date : - " + jdate);
                Console.WriteLine("Class : - " + classe);
                Console.WriteLine("Quota : - " + quota);
                passenger_detail();
            }
            else
            {
                Console.Write("Enter The No. of Senior Citizen : -- ");
                nsc = int.Parse(Console.ReadLine());
                pid = p.Next(1000);
                for (s_no = 1; s_no <= pass; s_no++)
                {
                    Console.WriteLine("S.No. : -- " + s_no);
                    Console.Write("Name : -- ");
                    name = Console.ReadLine();
                    Console.Write("Age : -- ");
                    age = int.Parse(Console.ReadLine());
                    Console.Write("Gender : -- ");
                    gender = Console.ReadLine();
                    if (age >= 58)
                    {
                        Console.WriteLine("Senior Citizen");
                        berth_prefer = "Lower berth";
                        Console.WriteLine("Berth Preference : - " + berth_prefer);
                    }
                    else
                    {
                        Console.Write("Berth Preference : -- ");
                        berth_prefer = Console.ReadLine();
                    }
                    Console.Write("Nationality : -- ");
                    nationality = Console.ReadLine();
                    cmd = new SqlCommand("insert into passenger_detail values ('" + name.ToUpper() + "','" + age + "','" + gender.ToUpper() + "','" + berth_prefer.ToUpper() + "','" + nationality.ToUpper() + "','" + pid + "')", con);
                    r = cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Your Pid is : - " + pid);
                Payment();
            }
            con.Close();

        }
        static Random RndNum = new Random();
        static Random RndNum1 = new Random();
        void Payment()
        {
            con = new SqlConnection(sq);
            if (sources == "New Delhi" && destination == "Agra Cantt" || sources == "Agra Cantt" && destination == "New Delhi")
            {
                switch (classe)
                {
                    case "Second Siting":
                        ng = pass - nsc;
                        bfare = 75; rcharge = 15;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Sleeper":
                        ng = pass - nsc;
                        bfare = 105; rcharge = 20;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Third AC":
                        ng = pass - nsc;
                        bfare = 180; rcharge = 25;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Second AC":
                        ng = pass - nsc;
                        bfare = 260; rcharge = 35;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "First AC":
                        ng = pass - nsc;
                        bfare = 350; rcharge = 40;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                }
                Console.Write("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Payment Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose Payment Method.\n");
                Console.WriteLine("1) Net Banking/Debit Card/Credit Card");
                Console.WriteLine("2) Cash Card/Wallet.");
                Console.WriteLine("Enter the choice from above ===> ");
                n = int.Parse(Console.ReadLine());
            }
            else if (sources == "Mathura" && destination == "New Delhi" || sources == "New Delhi" && destination == "Mathura")
            {
                con.Open();
                cmd = new SqlCommand("select *from Ticket_booking where classe='" + classe + "'", con);
                rd = cmd.ExecuteReader();
                con.Close();
                switch (classe)
                {
                    case "Second Siting":
                        ng = pass - nsc;
                        bfare = 55; rcharge = 15;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Third AC":
                        ng = pass - nsc;
                        bfare = 80; rcharge = 25;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Second AC":
                        ng = pass - nsc;
                        bfare = 150; rcharge = 35;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "First AC":
                        ng = pass - nsc;
                        bfare = 200; rcharge = 40;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                }
                Console.Write("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Payment Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose Payment Method.\n");
                Console.WriteLine("1) Net Banking/Debit Card/Credit Card");
                Console.WriteLine("2) Cash Card/Wallet.");
                Console.WriteLine("Enter the choice from above ===> ");
                n = int.Parse(Console.ReadLine());
            }
            else if (sources == "New Delhi" && destination == "Mumbai Central" || sources == "Mumbai Central" && destination == "New Delhi")
            {
                con.Open();
                cmd = new SqlCommand("select *from Ticket_booking where classe='" + classe + "'", con);
                rd = cmd.ExecuteReader();
                con.Close();
                switch (classe)
                {
                    case "Sleeper":
                        ng = pass - nsc;
                        bfare = 680; rcharge = 20;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Third AC":
                        ng = pass - nsc;
                        bfare = 1540; rcharge = 25;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Second AC":
                        ng = pass - nsc;
                        bfare = 2300; rcharge = 35;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "First AC":
                        ng = pass - nsc;
                        bfare = 3210; rcharge = 40;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                }
                Console.Write("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Payment Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose Payment Method.\n");
                Console.WriteLine("1) Net Banking/Debit Card/Credit Card");
                Console.WriteLine("2) Cash Card/Wallet.");
                Console.WriteLine("Enter the choice from above ===> ");
                n = int.Parse(Console.ReadLine());
            }
            else if (sources == "New Delhi" && destination == "Kolkata" || sources == "Kolkata" && destination == "New Delhi")
            {
                con.Open();
                cmd = new SqlCommand("select *from Ticket_booking where classe='" + classe + "'", con);
                rd = cmd.ExecuteReader();
                con.Close();
                switch (classe)
                {
                    case "Sleeper":
                        ng = pass - nsc;
                        bfare = 600; rcharge = 20;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Third AC":
                        ng = pass - nsc;
                        bfare = 1360; rcharge = 25;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Second AC":
                        ng = pass - nsc;
                        bfare = 1980; rcharge = 35;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "First AC":
                        ng = pass - nsc;
                        bfare = 3645; rcharge = 40;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                }
                Console.Write("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Payment Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose Payment Method.\n");
                Console.WriteLine("1) Net Banking/Debit Card/Credit Card");
                Console.WriteLine("2) Cash Card/Wallet.");
                Console.WriteLine("Enter the choice from above ===> ");
                n = int.Parse(Console.ReadLine());
            }
            else if (sources == "New Delhi" && destination == "Chennai Central" || sources == "Chennai Central" && destination == "New Delhi")
            {
                con.Open();
                cmd = new SqlCommand("select *from Ticket_booking where classe='" + classe + "'", con);
                rd = cmd.ExecuteReader();
                con.Close();
                switch (classe)
                {
                    case "Sleeper":
                        ng = pass - nsc;
                        bfare = 655; rcharge = 20;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Third AC":
                        ng = pass - nsc;
                        bfare = 1800; rcharge = 25;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Second AC":
                        ng = pass - nsc;
                        bfare = 3480; rcharge = 35;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "First AC":
                        ng = pass - nsc;
                        bfare = 4820; rcharge = 40;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                }
                Console.Write("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Payment Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose Payment Method.\n");
                Console.WriteLine("1) Net Banking/Debit Card/Credit Card");
                Console.WriteLine("2) Cash Card/Wallet.");
                Console.WriteLine("Enter the choice from above ===> ");
                n = int.Parse(Console.ReadLine());
            }
            else if (sources == "New Delhi" && destination == "Bhubaneswar" || sources == "Bhubaneswar" && destination == "New Delhi")
            {
                con.Open();
                cmd = new SqlCommand("select *from Ticket_booking where classe='" + classe + "'", con);
                rd = cmd.ExecuteReader();
                con.Close();
                switch (classe)
                {
                    case "Sleeper":
                        ng = pass - nsc;
                        bfare = 705; rcharge = 20;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Third AC":
                        ng = pass - nsc;
                        bfare = 1680; rcharge = 25;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Second AC":
                        ng = pass - nsc;
                        bfare = 2420; rcharge = 35;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "First AC":
                        ng = pass - nsc;
                        bfare = 4670; rcharge = 40;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                }
                Console.Write("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Payment Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose Payment Method.\n");
                Console.WriteLine("1) Net Banking/Debit Card/Credit Card");
                Console.WriteLine("2) Cash Card/Wallet.");
                Console.WriteLine("Enter the choice from above ===> ");
                n = int.Parse(Console.ReadLine());
            }
            else if (sources == "New Delhi" && destination == "Jammu Tawi" || sources == "Jammu Tawi" && destination == "New Delhi")
            {
                switch (classe)
                {
                    case "Sleeper":
                        ng = pass - nsc;
                        bfare = 450; rcharge = 20;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Third AC":
                        ng = pass - nsc;
                        bfare = 935; rcharge = 25;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "Second AC":
                        ng = pass - nsc;
                        bfare = 1320; rcharge = 35;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                    case "First AC":
                        ng = pass - nsc;
                        bfare = 2360; rcharge = 40;
                        stax = (bfare + rcharge) * 0.12;
                        if (o == 2)
                        {
                            tfare = (bfare + rcharge) + stax + 100;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair of Tatkal Booking is : -- " + tf);
                            }
                        }
                        else
                        {
                            tfare = (bfare + rcharge) + stax;
                            tf = tfare * ng;
                            if (age >= 58)
                            {
                                sc = tfare * 0.40;
                                tsc = ((tfare - sc) * nsc);
                                tf = tf + tsc;
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                            else
                            {
                                Console.WriteLine("Your Total Fair is : -- " + tf);
                            }
                        }
                        break;
                }
                Console.Write("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Payment Details");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose Payment Method.\n");
                Console.WriteLine("1) Net Banking/Debit Card/Credit Card");
                Console.WriteLine("2) Cash Card/Wallet.");
                Console.WriteLine("Enter the choice from above ===> ");
                n = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("On this Route Train is not available.");
                cmd = new SqlCommand("delete from Ticket_booking where tno ='" + tno + "'", con);
                rd = cmd.ExecuteReader();
                cmd = new SqlCommand("delete from passenger_detail where  ='" + name + "'", con);
                rd = cmd.ExecuteReader();
            }
            DateTime now = DateTime.Now;
            var dtf = DateTime.Now;
            switch (n)
            {
                case 1:
                    Console.WriteLine("Card Holder name : -- ");
                    cname = Console.ReadLine();
                    Console.WriteLine("Card no. : -- ");
                    cno = Int64.Parse(Console.ReadLine());
                    Console.WriteLine("Card Expiry Date : -- ");
                    cedate = Console.ReadLine();
                    Console.WriteLine("3 digit CVV no. : -- ");
                    cv = int.Parse(Console.ReadLine());
                    Console.WriteLine("Mobile no : -- ");
                    wmobile = Int64.Parse(Console.ReadLine());
                    con.Open();
                    pnr = (long)(RndNum.NextDouble() * 9999999999) + 1000000000;
                    tid = (long)(RndNum1.NextDouble() * 99999999) + 10000000;
                    cmd = new SqlCommand("insert into payment values('" + cname.ToUpper() + "','" + cno + "','" + cedate + "','" + cv + "','" + wmobile + "'," + tf + ",'" + pnr + "','" + tid + "','" + dtf + "')", con);
                    r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand("insert into Ticket_booking values('" + tno + "','" + tname + "','" + sources.ToUpper() + "','" + destination.ToUpper() + "','" + jdate.ToUpperInvariant() + "','" + classe.ToUpper() + "','" + quota.ToUpper() + "','" + pnr + "')", con);
                        r = cmd.ExecuteNonQuery();
                        con.Close();
                        Console.WriteLine("Payment done Successfully and Your Ticket is confirmed.");
                        Console.WriteLine("Your Pnr No. is :- " + pnr);
                        Console.WriteLine("Your Transaction Id is :- " + tid);
                        switch (classe)
                        {
                            case "First AC":
                                coachno = "H1";
                                Console.WriteLine("Coach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                            case "Second AC":
                                coachno = "A1";
                                Console.WriteLine("Coach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                            case "Third AC":
                                coachno = "B1";
                                Console.WriteLine("\nCoach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                            case "Sleeper":
                                coachno = "S1";
                                Console.WriteLine("\nCoach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                            case "Second Siting":
                                coachno = "D1";
                                Console.WriteLine("\nCoach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                        }
                        Console.ReadLine();
                        login();
                    }
                    else
                    {
                        Console.WriteLine("Payment is not done.");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Card name : -- ");
                    cname = Console.ReadLine();
                    Console.WriteLine("Cash Card no. : -- ");
                    cno = Int64.Parse(Console.ReadLine());
                    Console.WriteLine("Cash Card Expiry Date : -- ");
                    cedate = Console.ReadLine();
                    Console.WriteLine("Your mobile no. : -- ");
                    wmobile = Int64.Parse(Console.ReadLine());
                    Console.WriteLine("Cash Card Code : -- ");
                    cv = int.Parse(Console.ReadLine());
                    con.Open();
                    pnr = (long)(RndNum.NextDouble() * 9999999999) + 1000000000;
                    tid = (long)(RndNum1.NextDouble() * 99999999) + 10000000;
                    cmd = new SqlCommand("insert into payment values('" + cname.ToUpper() + "','" + cno + "','" + cedate + "','" + cv + "','" + wmobile + "'," + tf + ",'" + pnr + "','" + tid + "','" + dtf + "')", con);
                    r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand("insert into Ticket_booking values('" + tno + "','" + tname + "','" + sources.ToUpper() + "','" + destination.ToUpper() + "','" + jdate.ToUpperInvariant() + "','" + classe.ToUpper() + "','" + quota.ToUpper() + "','" + pnr + "')", con);
                        r = cmd.ExecuteNonQuery();
                        con.Close();
                        Console.WriteLine("Payment done Successfully and Your Ticket is confirmed.");
                        Console.WriteLine("Your Pnr No. is :- " + pnr);
                        Console.WriteLine("Your Transaction Id is :- " + tid);
                        switch (classe)
                        {
                            case "First AC":
                                coachno = "H1";
                                Console.WriteLine("Coach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                            case "Second AC":
                                coachno = "A1";
                                Console.WriteLine("Coach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                            case "Third AC":
                                coachno = "B1";
                                Console.WriteLine("\nCoach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                            case "Sleeper":
                                coachno = "S1";
                                Console.WriteLine("\nCoach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                            case "Second Siting":
                                coachno = "D1";
                                Console.WriteLine("\nCoach no. is : - " + coachno);
                                Console.Write("Seat no. is : - ");
                                for (int i = 0; i < pass; i++)
                                {
                                    sn = s.Next(100);
                                    Console.Write(sn + " ");
                                    con.Open();
                                    cmd = new SqlCommand("insert into passenger_details values ('" + sn + "','" + coachno + "','" + pnr + "')", con);
                                    r = cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                break;
                        }
                        Console.ReadLine();
                        

                    }
                    else
                    {
                        Console.WriteLine("Payment is not done.");
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("You Entered invalid choice.");
                    break;
            }
        }
        void Cancel_ticket()
        {
            con = new SqlConnection(sq);
            Console.Clear();
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
            Console.Write("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t\t\t\t\t\t\t     |\n");
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
            Console.WriteLine("\nEnter PNR Number ========>>>>>>>\t");
            pnr = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter PID ========>>>>>>>\t");
            pid = int.Parse(Console.ReadLine());
            con.Open();
            cmd = new SqlCommand("select pnr from passenger_details where pnr='" + pnr + "'", con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from passenger_detail where pid='" + pid + "'", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("\t--------------------------------------------");
                    Console.WriteLine("\t Name \t\t\t|\t" + rd[0].ToString());
                    Console.WriteLine("\t Age \t\t\t|\t" + rd[1].ToString());
                    Console.WriteLine("\t Gender \t\t|\t" + rd[2].ToString());
                    Console.WriteLine("\t Berth Preference \t|\t" + rd[3].ToString());
                    Console.WriteLine("\t Nationality \t\t|\t" + rd[4].ToString());
                    Console.WriteLine("\t--------------------------------------------\n");
                }
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from passenger_details where pnr='" + pnr + "'", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("\t--------------------------------------------");
                    Console.WriteLine("\t Seat No. \t\t|\t" + rd[0].ToString());
                    Console.WriteLine("\t Coach No. \t\t|\t" + rd[1].ToString());
                    Console.WriteLine("\t--------------------------------------------\n");
                }
                con.Close();
                con.Open();
                Console.WriteLine("Enter Full Name and Seat no. of Passenger which you want to cancel Ticket :----------  ");
                name = Console.ReadLine();
                sn = int.Parse(Console.ReadLine());
                cmd = new SqlCommand("delete from passenger_detail where name = '" + name + "' and pid='" + pid + "'", con);
                rd = cmd.ExecuteReader();
                con.Close();
                con.Open();
                cmd = new SqlCommand("delete from passenger_details where sn = '" + sn + "' and pnr='" + pnr + "'", con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Console.WriteLine("Sorry Error is Occured during cancel the Ticket.");
                }
                else
                {
                    Console.WriteLine("Ticket has been Canceled and your amount will be refunded in 24 hour.");
                }
            }
            else
            {
                Console.WriteLine("\nYour Entered Invalid PNR No.");
            }
        }
        void tdr()
        {
            con = new SqlConnection(sq);
            Console.Write("\nEnter Your Pnr No. : - ");
            pnr = long.Parse(Console.ReadLine());
            Console.Write("\nEnter Passenger Id : - ");
            pid = int.Parse(Console.ReadLine());
            con.Open();
            cmd = new SqlCommand("select pnr from passenger_details where pnr='" + pnr + "'", con);
            rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                Console.Clear();
                con.Close();
                Console.WriteLine("\n\t\t\t\t\t\t\t\tIRCTCs e-Ticketing Service");
                Console.WriteLine("\t\t\t\t\t\t\tElectronic Reservation Slip (Personal User)\n");
                Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
                Console.WriteLine("\n1) This ticket will only be valid along with an ID proof in original.If found travelling without ID Proof,Passenger will be treated as without ticket and charged as per extant Railway rules.");
                Console.WriteLine("2) Valid IDs to be presented during train journey by one of the passenger booked on an e­ticket :­ Voter Identity Card / Passport / PAN Card / Driving License / Aadhaar Card.");
                con.Open();
                cmd = new SqlCommand("select * from payment where pnr ='" + pnr + "'", con);
                rd = cmd.ExecuteReader();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Journey and Fare Deltails\n");
                while (rd.Read())
                {
                    Console.Write("\tPNR No. : - " + rd[6].ToString());
                    Console.WriteLine("\t\t\t\t\t\tTransaction ID : - " + rd[7].ToString());
                    Console.Write("\tDate of Booking : - " + rd[8].ToString());
                    Console.WriteLine("\t\t\tPassenger Mobile Number  : - " + rd[4].ToString());
                    Console.Write("\tTotal Fare : - " + rd[5].ToString());
                }
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from Ticket_booking where pnr='"+pnr+"'", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("\t\t\t\t\t\tTrain No. & Name : - " + rd[0].ToString()+" / " + rd[1].ToString());
                    Console.Write("\tFrom : - " + rd[2].ToString());
                    Console.WriteLine("\t\t\t\t\t\tTo : - " + rd[3].ToString());
                    Console.Write("\tDate of Journey : - " + rd[4].ToString());
                    Console.WriteLine("\t\t\t\tClass : - " + rd[5].ToString());
                    Console.Write("\tQuota : - " + rd[6].ToString());
                    Console.WriteLine("\t\t\t\t\t\tBoarding : - " + rd[2].ToString());
                    Console.WriteLine("\tDate of Boarding : - " + rd[4].ToString());
                }
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from passenger_detail where pid='" + pid + "'", con);
                rd = cmd.ExecuteReader();
                Console.WriteLine("\nPassenger Details\n");
                while (rd.Read())
                {
                    Console.Write("\tName : - " + rd[0].ToString());
                    Console.WriteLine("\t\t\tAge : - " + rd[1].ToString());
                    Console.Write("\tSex : - " + rd[2].ToString());
                    Console.WriteLine("\t\t\t\tBerth : - " + rd[3].ToString());
                }
                con.Close();
                con.Open();
                cmd = new SqlCommand("select * from passenger_details where pnr='" + pnr + "'", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Console.Write("\tSeat No. : - " + rd[0].ToString());
                    Console.WriteLine("\t\t\t\tCurrent Status / Coach No. : - Confirm / " + rd[1].ToString());
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                con.Close();
            }
            else
            {
                Console.WriteLine("\nYour Enter Invalid PNR No.");
            }
            
        }
        void My_Transaction()
        {
            con = new SqlConnection(sq);
            con.Open();
            Console.Write("\nEnter Transaction ID =======>  ");
            tid = long.Parse(Console.ReadLine());
            cmd = new SqlCommand("select * from payment where tid='" + tid + "'",con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Console.WriteLine("\nYour Last Transaction Detail is given below : -\n");
                Console.WriteLine("Transaction ID : - " + rd[7].ToString());
                Console.WriteLine("Transaction Date : - " + rd[8].ToString());
                Console.WriteLine("Total Amount : - " + rd[5].ToString());
                Console.WriteLine("Mobile No. : -" + rd[4].ToString());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You Entered Invalid Transaction ID.");
            }
            con.Close();
        }
        void My_Profile()
        {
            con = new SqlConnection(sq);
            Console.WriteLine("Enter User_Id ====> ");
            userid = Console.ReadLine();
            con.Open();
            cmd = new SqlCommand("select userid from reg where userid='" + userid + "'", con);
            rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                con.Close();
                con.Open();
                Console.WriteLine("\t1) Update the First name");
                Console.WriteLine("\t2) Update the Middle name");
                Console.WriteLine("\t3) Update the Last name");
                Console.WriteLine("\t4) Update the Gender");
                Console.WriteLine("\t5) Update the Marital Status");
                Console.WriteLine("\t6) Update the Date Of Birth");
                Console.WriteLine("\t7) Update the Mobile no.");
                Console.WriteLine("\t8) Update the Email ID");
                Console.WriteLine("\t9) Update the Address");
                Console.WriteLine("\t10) Update the Pincode");
                Console.WriteLine("\t11) Update the State");
                Console.WriteLine("\t12) Update the City");
                Console.Write("\n\tEnter the choices from above 12 :- ");
                int up = int.Parse(Console.ReadLine());
                switch (up)
                {
                    case 1:
                        Console.Write("\n\tEnter new First name :- ");
                        fname = Console.ReadLine();
                        cmd = new SqlCommand("update reg set fname = '" + fname.ToUpper() + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 2:
                        Console.Write("\n\tEnter new Middle name :- ");
                        mname = Console.ReadLine();
                        cmd = new SqlCommand("update reg set mname = '" + mname.ToUpper() + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 3:
                        Console.Write("\n\tEnter new Last name :- ");
                        lname = Console.ReadLine();
                        cmd = new SqlCommand("update reg set lname = '" + lname.ToUpper() + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 4:
                        Console.Write("\n\tEnter new Gender :- ");
                        gender = Console.ReadLine();
                        cmd = new SqlCommand("update reg set gender = '" + gender.ToUpper() + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 5:
                        Console.Write("\n\tEnter new Marital Status name :- ");
                        ms = Console.ReadLine();
                        cmd = new SqlCommand("update reg set ms = '" + ms.ToUpper() + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 6:
                        Console.Write("\n\tEnter new Date Of Birth :- ");
                        dob = Console.ReadLine();
                        cmd = new SqlCommand("update reg set dob = '" + dob.ToUpper() + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 7:
                        Console.Write("\n\tEnter new Mobile no. :- ");
                        mobile = Int64.Parse(Console.ReadLine());
                        cmd = new SqlCommand("update reg set mobile = '" + mobile + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 8:
                        Console.Write("\n\tEnter new Email ID :- ");
                        email = Console.ReadLine();
                        cmd = new SqlCommand("update reg set email = '" + email + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 9:
                        Console.Write("\n\tEnter new Address :- ");
                        full_add = Console.ReadLine();
                        cmd = new SqlCommand("update reg set full_add = '" + full_add.ToUpper() + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 10:
                        Console.Write("\n\tEnter new Pincode :- ");
                        pin = int.Parse(Console.ReadLine());
                        cmd = new SqlCommand("update reg set pin = '" + pin + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 11:
                        Console.Write("\n\tEnter new State :- ");
                        states = Console.ReadLine();
                        cmd = new SqlCommand("update reg set states = '" + states.ToUpper() + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    case 12:
                        Console.Write("\n\tEnter new City :- ");
                        city = Console.ReadLine();
                        cmd = new SqlCommand("update reg set city = '" + city.ToUpper() + "'where userid = '" + userid + "'", con);
                        rd = cmd.ExecuteReader();
                        Console.Write("\tUpdation successful");
                        break;
                    default:
                        Console.Write("\n\tYou Entered Wrong Choice");
                        break;
                }
                con.Close();
            }
            else
            {
                Console.WriteLine("\nYou Entered Invalid User ID.");
            }            
        }
        static void Main(string[] args)
        {
            Reservation r = new Reservation();
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*\n|");
            Console.WriteLine("\t\t\t\t\t\t\tIndian Railway Catering and Tourism Corporation Limited\t                                                     |");
            Console.Write("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
            Console.WriteLine("\n\n\t\t1) Login");
            Console.WriteLine("\n\t\t2) Sign Up");
            Console.Write("\n\n\t\tEnter the choice from above : - ");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    r.login();
                    break;
                case 2:
                    r.signup();
                    break;
                default:
                    Console.WriteLine("\n\t\tYou Entered Invalid Choice, Please Enter Valid Choice & try again....");
                    break;
            }

         }
    }
}