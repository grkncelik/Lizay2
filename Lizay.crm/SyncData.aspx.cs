using System;
using System.Configuration;
using Lizay.dll.CaniasWS;
using Newtonsoft.Json.Linq;

namespace Lizay.crm
{
    public partial class SyncData : System.Web.UI.Page
    {
        string docDatem = DateTime.Now.Month.ToString();
        string docDaTey = DateTime.Now.Year.ToString();
        string docDatDay = DateTime.Now.Day.ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            var time = DateTime.Now.Hour;

            if (!(time > 9 && time < 23))
                return;

            var date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
            var date1 = firstDayOfMonth.ToShortDateString().Replace("/", ".");
            var date2 = lastDayOfMonth.ToShortDateString().Replace("/", ".");
            var yearGlobal = DateTime.Now.Year.ToString();
            var monthGlobal = DateTime.Now.Month.ToString();

            var str = "0,30," + date1 + "," + date2 + ",1,1," + yearGlobal + "," + monthGlobal + "";
            CompanyData30(str);

            str = "0,40," + date1 + "," + date2 + ",1,1," + yearGlobal + "," + monthGlobal + "";
            CompanyData40(str);

            str = "0,41," + date1 + "," + date2 + ",1,1," + yearGlobal + "," + monthGlobal + "";
            CompanyData41(str);

            str = "0,42," + date1 + "," + date2 + ",1,1," + yearGlobal + "," + monthGlobal + "";
            CompanyData42(str);

            str = "0,30," + date1 + "," + date2 + ",0,1," + yearGlobal + "," + monthGlobal + "";
            PersonData30(str);

            str = "0,40," + date1 + "," + date2 + ",0,1," + yearGlobal + "," + monthGlobal + "";
            PersonData40(str);

            str = "0,41," + date1 + "," + date2 + ",0,1," + yearGlobal + "," + monthGlobal + "";
            PersonData41(str);

            str = "0,42," + date1 + "," + date2 + ",0,1," + yearGlobal + "," + monthGlobal + "";
            PersonData42(str);

            str = "2,30," + DateTime.Now.ToShortDateString().Replace("/", ".") + "," + DateTime.Now.ToShortDateString().Replace("/", ".") + ",1,1," + DateTime.Now.Year + "," + DateTime.Now.Month.ToString("0#") + "";
            CompanySalesTargetData(str);

            // PersonelListData();
        }

        void SendMail(string message)
        {
            try
            {
                var fromMail = ConfigurationSettings.AppSettings["FromMailAdress"];
                var toMailAdress = ConfigurationSettings.AppSettings["ToMailAdress"];
                var credentials = ConfigurationSettings.AppSettings["Credentials"];
                var credentialsPass = ConfigurationSettings.AppSettings["CredentialsPass"];
                var port = ConfigurationSettings.AppSettings["Port"];

                var email = new System.Net.Mail.MailMessage { From = new System.Net.Mail.MailAddress(fromMail) };
                var toMailAddressArray = toMailAdress.Split(';');

                foreach (var t in toMailAddressArray)
                {
                    email.To.Add(t);
                }

                email.Subject = "Lizay App Senk. Hatası";
                email.Body = "Hata : " + message;
                email.IsBodyHtml = true;

                var client = new System.Net.Mail.SmtpClient
                {
                    Credentials = new System.Net.NetworkCredential(credentials, credentialsPass),
                    Port = Convert.ToInt32(port),
                    Host = ConfigurationSettings.AppSettings["Host"],
                    EnableSsl = false
                };
                client.Send(email);
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        //Mağaza Satış Dataları 30
        public void CompanyData30(string strarg)
        {
            var caniasWebServiceNew = new iasWebServiceImplService();
            var sessionId = "";
            try
            {
                sessionId = caniasWebServiceNew.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

                var resp = caniasWebServiceNew.callIASService(sessionId, "mobilExpenseList", strarg, "STRING", true);

                var jsonString = resp.ToString();
                caniasWebServiceNew.logout(sessionId);

                var jsonVal = JArray.Parse(jsonString);
                dynamic list = jsonVal;

                if (jsonVal.Count > 0)
                {
                    dll.method.MOBILEXPENSELIST.DeleteData("30", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), "MAĞAZA");
                }

                foreach (var x in list)
                {
                    dll.method.MOBILEXPENSELIST.AddData(new dll.entity.MOBILEXPENSELIST
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
                        DOCDATEM = docDatem,
                        DOCDATEY = docDaTey,
                        DOCDATDAY = docDatDay

                    });

                }
                
                Label1.Text = jsonVal.Count + " Adet mağaza kaydı aktarılmıştır.";
                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanyData30", jsonVal.Count + " Adet mağaza kaydı aktarılmıştır.", "OK");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(sessionId))
                {
                    caniasWebServiceNew.logout(sessionId);
                }

                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanyData30", "Hata: " + ex.Message.Replace(",", ""), "FAILED");
                SendMail("Method Name: CompanyData30 <br/>Hata : " + ex.Message);
            }
        }

        //Mağaza Satış Dataları 40
        public void CompanyData40(string strarg)
        {
            var caniasWebServiceNew = new iasWebServiceImplService();
            var sessionId = "";

            try
            {

                sessionId = caniasWebServiceNew.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

                var resp = caniasWebServiceNew.callIASService(sessionId, "mobilExpenseList", strarg, "STRING", true);

                var jsonString = resp.ToString();
                caniasWebServiceNew.logout(sessionId);

                var jsonVal = JArray.Parse(jsonString);
                dynamic lizayList = jsonVal;

                if (jsonVal.Count > 0)
                {
                    dll.method.MOBILEXPENSELIST.DeleteData("40", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), "MAĞAZA");
                }

                foreach (var x in lizayList)
                {
                    dll.method.MOBILEXPENSELIST.AddData(new dll.entity.MOBILEXPENSELIST
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
                        DOCDATEM = docDatem,
                        DOCDATEY = docDaTey,
                        DOCDATDAY = docDatDay

                    });

                }

                Label1.Text = jsonVal.Count + " Adet mağaza kaydı aktarılmıştır.";
                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanyData40", jsonVal.Count + " Adet mağaza kaydı aktarılmıştır.", "OK");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(sessionId))
                {
                    caniasWebServiceNew.logout(sessionId);
                }

                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanyData40", "Hata: " + ex.Message.Replace(",", ""), "FAILED");
                SendMail("Method Name: CompanyData40 <br/>Hata : " + ex.Message);
            }

        }

        //Mağaza Satış Dataları 41
        public void CompanyData41(string strarg)
        {
            var caniasWebServiceNew = new iasWebServiceImplService();
            var sessionId = "";

            try
            {
                sessionId = caniasWebServiceNew.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

                var resp = caniasWebServiceNew.callIASService(sessionId, "mobilExpenseList", strarg, "STRING", true);

                var jsonString = resp.ToString();
                caniasWebServiceNew.logout(sessionId);

                var jsonVal = JArray.Parse(jsonString);
                dynamic list = jsonVal;

                if (jsonVal.Count > 0)
                {
                    dll.method.MOBILEXPENSELIST.DeleteData("41", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), "MAĞAZA");
                }

                foreach (dynamic x in list)
                {
                    dll.method.MOBILEXPENSELIST.AddData(new dll.entity.MOBILEXPENSELIST
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
                        DOCDATEM = docDatem,
                        DOCDATEY = docDaTey,
                        DOCDATDAY = docDatDay
                    });

                }

                Label1.Text = jsonVal.Count.ToString() + " Adet mağaza kaydı aktarılmıştır.";
                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanyData41", jsonVal.Count.ToString() + " Adet mağaza kaydı aktarılmıştır.", "OK");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(sessionId))
                {
                    caniasWebServiceNew.logout(sessionId);
                }

                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanyData41", "Hata: " + ex.Message.Replace(",", ""), "FAILED");
                SendMail("Method Name: CompanyData41 <br/>Hata : " + ex.Message);
            }
        }

        //Mağaza Satış Dataları 42
        public void CompanyData42(string strarg)
        {
            var caniasWebServiceNew = new iasWebServiceImplService();
            var sessionId = "";
            try
            {
                sessionId = caniasWebServiceNew.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

                var resp = caniasWebServiceNew.callIASService(sessionId, "mobilExpenseList", strarg, "STRING", true);

                var jsonString = resp.ToString();
                caniasWebServiceNew.logout(sessionId);

                var jsonVal = JArray.Parse(jsonString);
                dynamic list = jsonVal;

                if (jsonVal.Count > 0)
                {
                    dll.method.MOBILEXPENSELIST.DeleteData("42", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), "MAĞAZA");
                }

                foreach (dynamic x in list)
                {
                    dll.method.MOBILEXPENSELIST.AddData(new dll.entity.MOBILEXPENSELIST
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
                        DOCDATEM = docDatem,
                        DOCDATEY = docDaTey,
                        DOCDATDAY = docDatDay
                    });

                }

                Label1.Text = jsonVal.Count + " Adet mağaza kaydı aktarılmıştır.";
                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanyData42", jsonVal.Count + " Adet mağaza kaydı aktarılmıştır.", "OK");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(sessionId))
                {
                    caniasWebServiceNew.logout(sessionId);
                }

                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanyData42", "Hata: " + ex.Message.Replace(",", ""), "FAILED");
                SendMail("Method Name: CompanyData42 <br/>Hata : " + ex.Message);
            }
        }

        //Personel Satış Dataları 30
        public void PersonData30(string strarg)
        {
            var caniasWebServiceYeni = new iasWebServiceImplService();
            var sessionid = "";
            try
            {
                sessionid = caniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

                object resp = caniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", strarg, "STRING", true);

                string jsonString = resp.ToString();
                caniasWebServiceYeni.logout(sessionid);

                JArray jsonVal = JArray.Parse(jsonString);
                dynamic lizaylist = jsonVal;

                if (jsonVal.Count > 0)
                {
                    dll.method.MOBILEXPENSELIST.DeleteData("30", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), "PERSONEL");
                }

                foreach (dynamic x in lizaylist)
                {
                    dll.method.MOBILEXPENSELIST.AddData(new dll.entity.MOBILEXPENSELIST
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
                        DOCDATEM = docDatem,
                        DOCDATEY = docDaTey,
                        DOCDATDAY = docDatDay
                    });

                }

                Label2.Text = jsonVal.Count + " Adet personel kaydı aktarılmıştır.";
                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: PersonData30", jsonVal.Count + " Adet personel kaydı aktarılmıştır.", "OK");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(sessionid))
                {
                    caniasWebServiceYeni.logout(sessionid);
                }

                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: PersonData30", "Hata: " + ex.Message.Replace(",", ""), "FAILED");
                SendMail("Method Name: PersonData30 <br/>Hata : " + ex.Message);
            }
        }

        //Personel Satış Dataları 40
        public void PersonData40(string strarg)
        {
            var caniasWebServiceYeni = new iasWebServiceImplService();
            var sessionid = "";
            try
            {
                sessionid = caniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

                object resp = caniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", strarg, "STRING", true);

                string jsonString = resp.ToString();
                caniasWebServiceYeni.logout(sessionid);

                JArray jsonVal = JArray.Parse(jsonString);
                dynamic lizaylist = jsonVal;

                if (jsonVal.Count > 0)
                {
                    dll.method.MOBILEXPENSELIST.DeleteData("40", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), "PERSONEL");
                }

                foreach (dynamic x in lizaylist)
                {
                    dll.method.MOBILEXPENSELIST.AddData(new dll.entity.MOBILEXPENSELIST
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
                        DOCDATEM = docDatem,
                        DOCDATEY = docDaTey,
                        DOCDATDAY = docDatDay

                    });

                }

                Label2.Text = jsonVal.Count + " Adet personel kaydı aktarılmıştır.";
                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: PersonData40", jsonVal.Count + " Adet personel kaydı aktarılmıştır.", "OK");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(sessionid))
                {
                    caniasWebServiceYeni.logout(sessionid);
                }

                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: PersonData40", "Hata: " + ex.Message.Replace(",", ""), "FAILED");
                SendMail("Method Name: PersonData40 <br/>Hata : " + ex.Message);
            }
        }

        //Personel Satış Dataları 41
        public void PersonData41(string strarg)
        {
            var caniasWebServiceYeni = new iasWebServiceImplService();
            var sessionid = "";
            try
            {
                sessionid = caniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

                object resp = caniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", strarg, "STRING", true);

                string jsonString = resp.ToString();
                caniasWebServiceYeni.logout(sessionid);

                JArray jsonVal = JArray.Parse(jsonString);
                dynamic lizaylist = jsonVal;

                if (jsonVal.Count > 0)
                {
                    dll.method.MOBILEXPENSELIST.DeleteData("41", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), "PERSONEL");
                }

                foreach (dynamic x in lizaylist)
                {
                    dll.method.MOBILEXPENSELIST.AddData(new dll.entity.MOBILEXPENSELIST()
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
                        DOCDATEM = docDatem,
                        DOCDATEY = docDaTey,
                        DOCDATDAY = docDatDay
                    });

                }

                Label2.Text = jsonVal.Count + " Adet personel kaydı aktarılmıştır.";
                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: PersonData41", jsonVal.Count + " Adet personel kaydı aktarılmıştır.", "OK");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(sessionid))
                {
                    caniasWebServiceYeni.logout(sessionid);
                }

                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: PersonData41", "Hata: " + ex.Message.Replace(",", ""), "FAILED");
                SendMail("Method Name: PersonData41 <br/>Hata : " + ex.Message);
            }
        }

        //Personel Satış Dataları 42
        public void PersonData42(string strarg)
        {
            var caniasWebServiceYeni = new iasWebServiceImplService();
            var sessionid = "";
            try
            {
                sessionid = caniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

                object resp = caniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", strarg, "STRING", true);

                string jsonString = resp.ToString();
                caniasWebServiceYeni.logout(sessionid);

                JArray jsonVal = JArray.Parse(jsonString);
                dynamic lizaylist = jsonVal;

                if (jsonVal.Count > 0)
                {
                    dll.method.MOBILEXPENSELIST.DeleteData("42", DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), "PERSONEL");
                }

                foreach (dynamic x in lizaylist)
                {
                    dll.method.MOBILEXPENSELIST.AddData(new dll.entity.MOBILEXPENSELIST
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
                        DOCDATEM = docDatem,
                        DOCDATEY = docDaTey,
                        DOCDATDAY = docDatDay
                    });

                }

                Label2.Text = jsonVal.Count + " Adet personel kaydı aktarılmıştır.";
                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: PersonData42", jsonVal.Count + " Adet personel kaydı aktarılmıştır.", "OK");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(sessionid))
                {
                    caniasWebServiceYeni.logout(sessionid);
                }

                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: PersonData42", "Hata: " + ex.Message.Replace(",", ""), "FAILED");
                SendMail("Method Name: PersonData42 <br/>Hata : " + ex.Message);
            }
        }

        //Personel Listesi
        public void PersonelListData()
        {
            var caniasWebServiceYeni = new iasWebServiceImplService();
            string sessionid = caniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");


            string strarg = "1,40," + DateTime.Now.ToShortDateString() + "," + DateTime.Now.ToShortDateString() + ",1,1," + DateTime.Now.Year.ToString() + "," + DateTime.Now.Month.ToString("0#") + "";
            //object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "1,40,16.01.2018,20.02.2018,1,1", "STRING", true);
            object resp = caniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", strarg, "STRING", true);
            //object resp = CaniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", "2,40,01.01.2018,20.03.2018,1,1,2018,02", "STRING", true);

            string jsonString = resp.ToString();
            caniasWebServiceYeni.logout(sessionid);

            var jsonVal = JArray.Parse(jsonString);

            //JSONData d = new JSONData();
            //foreach (dynamic x in lizaylist)
            //{
            //    string splitData = x.PERSTEXT.ToString();
            //    string[] FullName = splitData.Split(' ');
            //    string Name = "";
            //    string Surname = "";
            //    if (FullName.Length > 2)
            //    {
            //        Name = FullName[0] + " " + FullName[1];
            //        Surname = FullName[2];
            //    }
            //    else
            //    {
            //        Name = FullName[0];
            //        Surname = FullName[1];
            //    }


            //    Lizay.dll.method.MOBILUSERLIST.AddUserData(new Lizay.dll.entity.MOBILUSERLIST()
            //    {
            //        PERSID = x.PERSID.ToString(),
            //        DISPLAY = x.PERSTEXT.ToString(),
            //        DEPARTMENT = x.PERSBUSA.ToString(),
            //        DEPARTMENTT = x.PERSBUSATEXT.ToString(),
            //        BIRTHDAY = "",
            //        NAME = Name.ToString(),
            //        SURNAME = Surname.ToString(),
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
        public void CompanySalesTargetData(string strarg)
        {
            var caniasWebServiceYeni = new iasWebServiceImplService();
            var sessionid = "";

            try
            {
                sessionid = caniasWebServiceYeni.login("00", "T", "NEW", "CANIAS", "192.168.1.50:27499/S2", "WSLIZAY", "Ws-123lizay");

                object resp = caniasWebServiceYeni.callIASService(sessionid, "mobilExpenseList", strarg, "STRING", true);


                string jsonString = resp.ToString();
                caniasWebServiceYeni.logout(sessionid);

                var jsonVal = JArray.Parse(jsonString);
                dynamic lizaylist = jsonVal;

                if (jsonVal.Count > 0)
                {
                    dll.method.COMPANYTARGETRATE.DeleteCompanyTargetData();
                }

                foreach (dynamic x in lizaylist)
                {
                    dll.method.COMPANYTARGETRATE.AddCompanyTargetData(new dll.entity.COMPANYTARGETRATE
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

                Label2.Text = jsonVal.Count + " Adet mağaza hedef kaydı aktarılmıştır.";
                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanySalesTargetData", jsonVal.Count + " Adet mağaza hedef kaydı aktarılmıştır.", "OK");
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(sessionid))
                {
                    caniasWebServiceYeni.logout(sessionid);
                }

                dll.method.MOBILEXPENSELIST.LogAdd("Method Name: CompanySalesTargetData", "Hata: " + ex.Message, "FAILED");
                SendMail("Method Name: CompanySalesTargetData <br/>Hata : " + ex.Message);
            }
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