using Lizay.dll.CaniasWS;
using Newtonsoft.Json.Linq;
using PushSharp.Apple;
using PushSharp.Google;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lizay.crm
{
    public partial class SyncData2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //CompanyData();

            //PersonData();

            //PersonelListData();

            //CompanySalesTargetData();

            SetRosette();

        }

        public void SetRosette()
        {

            List<dll.entity.MOBILEXPENSELIST> encoksatanmagaza;

            encoksatanmagaza = Lizay.dll.method.MOBILEXPENSELIST.Get_EnCokSatanMagaza();

            string encoksatanbirinci = encoksatanmagaza[0].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = encoksatanbirinci,
                USER_ID = "000",
                BADGE_ID = 1,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string encoksatanikinci = encoksatanmagaza[1].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = encoksatanikinci,
                USER_ID = "000",
                BADGE_ID = 2,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string encoksatanucuncu = encoksatanmagaza[2].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = encoksatanucuncu,
                USER_ID = "000",
                BADGE_ID = 3,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });

            List<dll.entity.MOBILEXPENSELIST> enkarlisatanmagaza;

            enkarlisatanmagaza = Lizay.dll.method.MOBILEXPENSELIST.Get_EnKarliSatanMagaza();

            string enkarlisatanbirinci = enkarlisatanmagaza[0].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = enkarlisatanbirinci,
                USER_ID = "000",
                BADGE_ID = 4,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string enkarlisatanikinci = enkarlisatanmagaza[1].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = enkarlisatanikinci,
                USER_ID = "000",
                BADGE_ID = 5,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string enkarlisatanucuncu = enkarlisatanmagaza[2].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = enkarlisatanucuncu,
                USER_ID = "000",
                BADGE_ID = 6,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });


            List<dll.entity.MOBILEXPENSELIST> enbasarilipirlantasatanmagaza;

            enbasarilipirlantasatanmagaza = Lizay.dll.method.MOBILEXPENSELIST.Get_EnBasariliPirlantaSatanMagaza();
            string enbasarilipirlantasatanbirinci = enbasarilipirlantasatanmagaza[0].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = enbasarilipirlantasatanbirinci,
                USER_ID = "000",
                BADGE_ID = 7,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string enbasarilipirlantasatanikinci = enbasarilipirlantasatanmagaza[1].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = enbasarilipirlantasatanikinci,
                USER_ID = "000",
                BADGE_ID = 8,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string enbasarilipirlantasatanucuncu = enbasarilipirlantasatanmagaza[2].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = enbasarilipirlantasatanucuncu,
                USER_ID = "000",
                BADGE_ID = 9,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });


            List<dll.entity.MOBILEXPENSELIST> enbasarilialtinsatanmagaza;

            enbasarilialtinsatanmagaza = Lizay.dll.method.MOBILEXPENSELIST.Get_EnBasariliAltinSatanMagaza();
            string enbasarilialtinsatanbirinci = enbasarilialtinsatanmagaza[0].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = enbasarilialtinsatanbirinci,
                USER_ID = "000",
                BADGE_ID = 10,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string enbasarilialtinsatanikinci = enbasarilialtinsatanmagaza[1].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = enbasarilialtinsatanikinci,
                USER_ID = "000",
                BADGE_ID = 11,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string enbasarilialtinsatanucuncu = enbasarilialtinsatanmagaza[2].BUSAREA;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = enbasarilialtinsatanucuncu,
                USER_ID = "000",
                BADGE_ID = 12,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });

            string MagazaList = "";
            MagazaList += "'" + encoksatanbirinci + "'";
            MagazaList += ",'" + encoksatanikinci + "'";
            MagazaList += ",'" + encoksatanucuncu + "'";
            MagazaList += ",'" + enkarlisatanbirinci + "'";
            MagazaList += ",'" + enkarlisatanikinci + "'";
            MagazaList += ",'" + enkarlisatanucuncu + "'";
            MagazaList += ",'" + enbasarilipirlantasatanbirinci + "'";
            MagazaList += ",'" + enbasarilipirlantasatanikinci + "'";
            MagazaList += ",'" + enbasarilipirlantasatanucuncu + "'";
            MagazaList += ",'" + enbasarilialtinsatanbirinci + "'";
            MagazaList += ",'" + enbasarilialtinsatanikinci + "'";
            MagazaList += ",'" + enbasarilialtinsatanucuncu + "'";

            string Message = "Bu ay yeni bir Ödül Rozeti kazandınız.";
            string Header = "1 adet görüntülenmeyi bekleyen rozetiniz var!";
            string Url = "http://lizay.btkurumsal.xyz/Rozetler.aspx";
            var RegistrationIdListAndroid = Lizay.dll.method.USERS.Get_UserListIn("", "", "MUDUR", "", "", "1", MagazaList);
            var RegistrationIdListIOS = Lizay.dll.method.USERS.Get_UserListIn("", "", "", "MUDUR", "", "2", MagazaList);
            if (RegistrationIdListAndroid.Count > 0)
            {
                AndroidSend(RegistrationIdListAndroid, Message, Header, Url);
            }

            if (RegistrationIdListIOS.Count > 0)
            {
                IosSend(RegistrationIdListIOS, Message, Header, Url);
            }


            List<dll.entity.MOBILEXPENSELIST> encoksatanpersonel;

            encoksatanpersonel = Lizay.dll.method.MOBILEXPENSELIST.Get_EnCokSatanPersonel();

            string encoksatanpersonelbirinci = encoksatanpersonel[0].SALDEPT;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = "000",
                USER_ID = encoksatanpersonelbirinci,
                BADGE_ID = 14,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string encoksatanpersonelikinci = encoksatanpersonel[1].SALDEPT;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = "000",
                USER_ID = encoksatanpersonelikinci,
                BADGE_ID = 15,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string encoksatanpersonelucuncu = encoksatanpersonel[2].SALDEPT;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = "000",
                USER_ID = encoksatanpersonelucuncu,
                BADGE_ID = 16,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });


            List<dll.entity.MOBILEXPENSELIST> enkarlisatanpersonel;

            enkarlisatanpersonel = Lizay.dll.method.MOBILEXPENSELIST.Get_EnKarliSatanPersonel();

            string enkarlisatanpersonelbirinci = enkarlisatanpersonel[0].SALDEPT;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = "000",
                USER_ID = enkarlisatanpersonelbirinci,
                BADGE_ID = 17,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string enkarlisatanpersonelikinci = enkarlisatanpersonel[1].SALDEPT;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = "000",
                USER_ID = enkarlisatanpersonelikinci,
                BADGE_ID = 18,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });
            string enkarlisatanpersonelucuncu = enkarlisatanpersonel[2].SALDEPT;
            Lizay.dll.method.USER_BADGE.AddNewOdulMonthly(new dll.entity.USER_BADGE()
            {
                COMPANY_NO = "000",
                USER_ID = enkarlisatanpersonelucuncu,
                BADGE_ID = 19,
                ISACTIVE = true,
                CREATED_DATE = DateTime.Now,
                MODIFIED_DATE = DateTime.Now

            });

            string PersonelList = "";
            PersonelList += "'" + encoksatanpersonelbirinci + "'";
            PersonelList += ",'" + encoksatanpersonelikinci + "'";
            PersonelList += ",'" + encoksatanpersonelucuncu + "'";
            PersonelList += ",'" + enkarlisatanpersonelbirinci + "'";
            PersonelList += ",'" + enkarlisatanpersonelikinci + "'";
            PersonelList += ",'" + enkarlisatanpersonelucuncu + "'";

            string PersonelMessage = "Bu Ay yeni bir Ödül Rozeti kazandınız.";
            string PersonelHeader = "1 adet görüntülenmeyi bekleyen rozetiniz var!";
            string PersonelUrl = "http://lizay.btkurumsal.xyz/Rozetler.aspx";
            var PersonelRegistrationIdListAndroid = Lizay.dll.method.USERS.Get_UserListIn(PersonelList, "", "PERSONEL", "", "", "1");
            var PersonelRegistrationIdListIOS = Lizay.dll.method.USERS.Get_UserListIn(PersonelList, "", "", "PERSONEL", "", "2");
            if (PersonelRegistrationIdListAndroid.Count > 0)
            {
                AndroidSend(PersonelRegistrationIdListAndroid, PersonelMessage, PersonelHeader, PersonelUrl);
            }

            if (PersonelRegistrationIdListIOS.Count > 0)
            {
                IosSend(PersonelRegistrationIdListIOS, PersonelMessage, PersonelHeader, PersonelUrl);
            }


        }

        //Mağaza Satış Dataları
        public void CompanyData()
        {
            var CaniasWebServiceYeni = new iasWebServiceImplService();
            string sessionid = CaniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

            object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "0,40,01.03.2018,31.03.2018,1,1,2018,02", "STRING", true);
            //object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "40,16.01.2018,16.01.2018,0,1", "STRING", true);

            string jsonString = resp.ToString();
            CaniasWebServiceYeni.logout(sessionid);

            JArray jsonVal = JArray.Parse(jsonString) as JArray;
            dynamic lizaylist = jsonVal;

            JSONData d = new JSONData();
            foreach (dynamic x in lizaylist)
            {
                Lizay.dll.method.MOBILEXPENSELIST.AddData(new Lizay.dll.entity.MOBILEXPENSELIST()
                {
                    SATISD = x.SATISD.ToString(),
                    SALDEPT = x.SALDEPT.ToString(),
                    COMPANY = x.COMPANY.ToString(),
                    DOCTYPE = x.DOCTYPE.ToString(),
                    DOCNUM = x.DOCNUM.ToString(),
                    DOCDATE = x.DOCDATE.ToString(),
                    CUSTOMER = x.CUSTOMER.ToString(),
                    NAME1 = x.NAME1.ToString(),
                    CUSTGRP = x.CUSTGRP.ToString(),
                    COUNTRY = x.COUNTRY.ToString(),
                    DISCAMNT = x.DISCAMNT.ToString(),
                    CURRENCY = x.CURRENCY.ToString(),
                    ITEMNUM = x.ITEMNUM.ToString(),
                    MATERIAL = x.MATERIAL.ToString(),
                    MTEXT = x.MTEXT.ToString(),
                    QUANTITY = x.QUANTITY.ToString(),
                    QUNIT = x.QUNIT.ToString(),
                    BUSAREA = x.BUSAREA.ToString(),
                    SPRICE = x.SPRICE.ToString(),
                    PRICEFACTOR = x.PRICEFACTOR.ToString(),
                    GROSS = x.GROSS.ToString(),
                    TDISCAMNT = x.TDISCAMNT.ToString(),
                    DISCFROMHEAD = x.DISCFROMHEAD.ToString(),
                    SUBTOTAL = x.SUBTOTAL.ToString(),
                    ITENDORSE = x.ITENDORSE.ToString(),
                    MATTYPE = x.MATTYPE.ToString(),
                    MATGRP = x.MATGRP.ToString(),
                    EXHM = x.EXHM.ToString(),
                    EXHR = x.EXHR.ToString(),
                    MONTSUBTOTAL = x.MONTSUBTOTAL.ToString(),
                    YEARSUBTOTAL = x.YEARSUBTOTAL.ToString(),
                    MONTHQUANTITY = x.MONTHQUANTITY.ToString(),
                    YEARQUANTITY = x.YEARQUANTITY.ToString(),
                    ISVARIANT = x.ISVARIANT.ToString(),
                    QUANTITYX = x.QUANTITYX.ToString(),
                    TCOST = x.TCOST.ToString(),
                    BATCHNUM = x.BATCHNUM.ToString(),
                    TOTPROF = x.TOTPROF.ToString(),
                    TOTRATE = x.TOTRATE.ToString(),
                    PRINTEDINVNUM = x.PRINTEDINVNUM.ToString(),
                    MAINMATGRP = x.MAINMATGRP.ToString(),
                    PAYMCOND = x.PAYMCOND.ToString(),
                    PAYMTYPE = x.PAYMTYPE.ToString(),
                    SCMADEN = x.SCMADEN.ToString(),
                    SCGRUP = x.SCGRUP.ToString(),
                    SCTEMEL = x.SCTEMEL.ToString(),
                    SALDEPTX = x.SALDEPTX.ToString(),
                    PUAN = x.PUAN.ToString(),
                    TEGI = x.TEGI.ToString(),
                    TERW = x.TERW.ToString(),
                    INVTYPE = x.INVTYPE.ToString(),
                    DATATYPE = "MAĞAZA",

                });

            }

            Label1.Text = jsonVal.Count.ToString() + " Adet mağaza kaydı aktarılmıştır.";

        }

        //Personel Satış Dataları
        public void PersonData()
        {
            var CaniasWebServiceYeni = new iasWebServiceImplService();
            string sessionid = CaniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

            //object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "40,16.01.2018,16.01.2018,1,1", "STRING", true);
            object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "0,40,01.03.2018,31.03.2018,0,1", "STRING", true);

            string jsonString = resp.ToString();
            CaniasWebServiceYeni.logout(sessionid);

            JArray jsonVal = JArray.Parse(jsonString) as JArray;
            dynamic lizaylist = jsonVal;

            JSONData d = new JSONData();
            foreach (dynamic x in lizaylist)
            {
                Lizay.dll.method.MOBILEXPENSELIST.AddData(new Lizay.dll.entity.MOBILEXPENSELIST()
                {
                    SATISD = x.SATISD.ToString(),
                    SALDEPT = x.SALDEPT.ToString(),
                    COMPANY = x.COMPANY.ToString(),
                    DOCTYPE = x.DOCTYPE.ToString(),
                    DOCNUM = x.DOCNUM.ToString(),
                    DOCDATE = x.DOCDATE.ToString(),
                    CUSTOMER = x.CUSTOMER.ToString(),
                    NAME1 = x.NAME1.ToString(),
                    CUSTGRP = x.CUSTGRP.ToString(),
                    COUNTRY = x.COUNTRY.ToString(),
                    DISCAMNT = x.DISCAMNT.ToString(),
                    CURRENCY = x.CURRENCY.ToString(),
                    ITEMNUM = x.ITEMNUM.ToString(),
                    MATERIAL = x.MATERIAL.ToString(),
                    MTEXT = x.MTEXT.ToString(),
                    QUANTITY = x.QUANTITY.ToString(),
                    QUNIT = x.QUNIT.ToString(),
                    BUSAREA = x.BUSAREA.ToString(),
                    SPRICE = x.SPRICE.ToString(),
                    PRICEFACTOR = x.PRICEFACTOR.ToString(),
                    GROSS = x.GROSS.ToString(),
                    TDISCAMNT = x.TDISCAMNT.ToString(),
                    DISCFROMHEAD = x.DISCFROMHEAD.ToString(),
                    SUBTOTAL = x.SUBTOTAL.ToString(),
                    ITENDORSE = x.ITENDORSE.ToString(),
                    MATTYPE = x.MATTYPE.ToString(),
                    MATGRP = x.MATGRP.ToString(),
                    EXHM = x.EXHM.ToString(),
                    EXHR = x.EXHR.ToString(),
                    MONTSUBTOTAL = x.MONTSUBTOTAL.ToString(),
                    YEARSUBTOTAL = x.YEARSUBTOTAL.ToString(),
                    MONTHQUANTITY = x.MONTHQUANTITY.ToString(),
                    YEARQUANTITY = x.YEARQUANTITY.ToString(),
                    ISVARIANT = x.ISVARIANT.ToString(),
                    QUANTITYX = x.QUANTITYX.ToString(),
                    TCOST = x.TCOST.ToString(),
                    BATCHNUM = x.BATCHNUM.ToString(),
                    TOTPROF = x.TOTPROF.ToString(),
                    TOTRATE = x.TOTRATE.ToString(),
                    PRINTEDINVNUM = x.PRINTEDINVNUM.ToString(),
                    MAINMATGRP = x.MAINMATGRP.ToString(),
                    PAYMCOND = x.PAYMCOND.ToString(),
                    PAYMTYPE = x.PAYMTYPE.ToString(),
                    SCMADEN = x.SCMADEN.ToString(),
                    SCGRUP = x.SCGRUP.ToString(),
                    SCTEMEL = x.SCTEMEL.ToString(),
                    SALDEPTX = x.SALDEPTX.ToString(),
                    PUAN = x.PUAN.ToString(),
                    TEGI = x.TEGI.ToString(),
                    TERW = x.TERW.ToString(),
                    INVTYPE = x.INVTYPE.ToString(),
                    DATATYPE = "PERSONEL",

                });

            }

            Label2.Text = jsonVal.Count.ToString() + " Adet personel kaydı aktarılmıştır.";

        }

        //Personel Listesi
        public void PersonelListData()
        {
            var CaniasWebServiceYeni = new iasWebServiceImplService();
            string sessionid = CaniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

            //object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "1,40,16.01.2018,20.02.2018,1,1", "STRING", true);
            object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "1,40,16.01.2018,20.02.2018,1,1", "STRING", true);
            //object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "2,40,01.01.2018,20.03.2018,1,1,2018,02", "STRING", true);

            string jsonString = resp.ToString();
            CaniasWebServiceYeni.logout(sessionid);

            JArray jsonVal = JArray.Parse(jsonString) as JArray;
            dynamic lizaylist = jsonVal;

            JSONData d = new JSONData();
            //foreach (dynamic x in lizaylist)
            //{
            //    Lizay.dll.method.MOBILUSERLIST.AddUserData(new Lizay.dll.entity.MOBILUSERLIST()
            //    {
            //        PERSID = x.PERSID.ToString(),
            //        DISPLAY = x.PERSTEXT.ToString(),
            //        DEPARTMENT = x.PERSBUSA.ToString(),
            //        DEPARTMENTT = x.PERSBUSATEXT.ToString(),
            //        BIRTHDAY = "",
            //        NAME = x.PERSTEXT.ToString(),
            //        SURNAME = x.PERSTEXT.ToString(),
            //        PAY = x.PERSPAY.ToString(),
            //    });


            //    Lizay.dll.method.MOBILUSERLIST.AddCompanyData(new Lizay.dll.entity.MOBILUSERLIST()
            //    {
            //        DEPARTMENT = x.PERSBUSA.ToString(),
            //        DEPARTMENTT = x.PERSBUSATEXT.ToString(),
            //    });
            //}

            Label2.Text = jsonVal.Count.ToString() + " Adet personel ve mağaza kaydı aktarılmıştır.";

        }

        //Mağaza Hedef Dataları
        public void CompanySalesTargetData()
        {
            var CaniasWebServiceYeni = new iasWebServiceImplService();
            string sessionid = CaniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

            //object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "1,40,01.01.2018,20.03.2018,1,1,2018,02", "STRING", true);
            object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "2,40,01.03.2018,21.03.2018,1,1,2018,03", "STRING", true);

            string jsonString = resp.ToString();
            CaniasWebServiceYeni.logout(sessionid);

            JArray jsonVal = JArray.Parse(jsonString) as JArray;
            dynamic lizaylist = jsonVal;

            JSONData d = new JSONData();
            foreach (dynamic x in lizaylist)
            {
                Lizay.dll.method.COMPANYTARGETRATE.AddCompanyTargetData(new Lizay.dll.entity.COMPANYTARGETRATE()
                {
                    CLIENT = x.CLIENT.ToString(),
                    COMPANY = x.COMPANY.ToString(),
                    FINYEAR = x.FINYEAR.ToString(),
                    FINPERIOD = x.FINPERIOD.ToString(),
                    TOTALORAN = x.TOTALORAN.ToString(),
                    BUSAREA = x.BUSAREA.ToString(),
                    STEXT = x.STEXT.ToString(),
                    PLAIN = x.PLAIN.ToString(),
                    MAGAZAORAN = x.MAGAZAORAN.ToString(),
                    CURRENCY = "TL",
                });


            }

            Label2.Text = jsonVal.Count.ToString() + " Adet mağaza hedef kaydı aktarılmıştır.";

        }



        private void AndroidSend(List<Lizay.dll.entity.USERS> users, string Message, string Header, string Url)
        {
            var task = Task.Factory.StartNew(
            state =>
            {
                var context = (HttpContext)state;
                var token = ConfigurationManager.AppSettings["GoogleKeyForParent"];
                if (users.Count <= 0)
                    return;
                var config = new GcmConfiguration("", token, null);
                var gcmBroker = new GcmServiceBroker(config);
                gcmBroker.Start();


                foreach (var item in users)
                {
                    // Queue a notification to send
                    gcmBroker.QueueNotification(new GcmNotification
                    {
                        RegistrationIds = new List<string> {
                                item.DEVICE_ID
                        },
                        Data = JObject.Parse("{\"alert\":\"" + Message + "\",\"badge\":0,\"sound\":\"sound.caf\",\"Header\":\"" + Header + "\",\"Text\":\"" + Message + "\",\"Url\":\"" + Url + "\"}")
                    });
                }

                gcmBroker.Stop();
            }, HttpContext.Current);
        }


        private void IosSend(List<Lizay.dll.entity.USERS> users, string Message, string Header, string Url)
        {
            //var task = Task.Factory.StartNew(
            //state =>
            //{
            var context = HttpContext.Current;
            if (users.Count <= 0)
                return;
            var pass = ConfigurationManager.AppSettings["IosCerPass"];
            var path = string.Empty;

            if (HttpRuntime.AppDomainAppId != null)
            {
                path = context.Server.MapPath("~/Cer/" + "ios.p12");
            }
            else
            {
                path = @"C:\inetpub\wwwroot\lizayapp\Cer\ios.p12";
            }

            var config = new ApnsConfiguration(ApnsConfiguration.ApnsServerEnvironment.Production, path, pass)
            {


            };
            var apnsBroker = new ApnsServiceBroker(config);

            apnsBroker.Start();

            apnsBroker.OnNotificationFailed += (notification, aggregateEx) =>
            {

                aggregateEx.Handle(ex =>
                {

                    // See what kind of exception it was to further diagnose
                    if (ex is ApnsNotificationException)
                    {
                        var notificationException = (ApnsNotificationException)ex;

                        // Deal with the failed notification
                        var apnsNotification = notificationException.Notification;
                        var statusCode = notificationException.ErrorStatusCode;

                        Console.WriteLine($"Apple Notification Failed: ID={apnsNotification.Identifier}, Code={statusCode}");

                    }
                    else
                    {
                        // Inner exception might hold more useful information like an ApnsConnectionException			
                        Console.WriteLine($"Apple Notification Failed for some unknown reason : {ex.InnerException}");
                    }

                    // Mark it as handled
                    return true;
                });
            };

            foreach (var item in users)
            {
                //var badge = MessageUtils.GetUnReadedMessages(item) + MessageUtils.GetUnreadedContactMessage(item);
                var badge = 0;

                apnsBroker.QueueNotification(new ApnsNotification
                {
                    DeviceToken = item.DEVICE_ID,
                    //Payload = JObject.Parse("{\"aps\":{\"badge\":1,\"Header\":\"" + model.Header + "\",\"Text\":\"" + model.Message + "\",\"Url\":\"" + model.Url + "\"}}")
                    Payload = JObject.Parse("{\"aps\":{\"alert\":\"" + Message + "\",\"badge\":\"" + badge + "\",\"sound\":\"default\",\"Header\":\"" + Header + "\",\"Text\":\"" + Message + "\",\"Url\":\"" + Url + "\"}}")
                });


            }
            apnsBroker.Stop();
            //},
            //HttpContext.Current);
        }


        public class JSONData
        {

            public string SALDEPT { get; set; }
            public string MATERIAL { get; set; }
            public string MTEXT { get; set; }
            public string SUBTOTAL { get; set; }
            public string DOCDATE { get; set; }
            public string SALDEPTX { get; set; }

        }
    }
}