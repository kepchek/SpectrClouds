using System;
          using System.Text;
          using System.Globalization;
          using System.Security.Cryptography;
using UnityEngine;
using JetBrains.Annotations;

public partial class Payment : MonoBehaviour
          {
            public static string LinkButtonPay;
            int IsTest = 1;
            protected void Page_Load(object sender, EventArgs e)
            {
              // your registration data
              string sMrchLogin = "test";
              string sMrchPass1 = "securepass1";
              // order properties
              decimal nOutSum = 5.12M;
              int nInvId = 5;
              string sDesc = "desc";
              
              
              
              string sOutSum = nOutSum.ToString("1.00", CultureInfo.InvariantCulture);
              string sCrcBase = string.Format("{0}:{1}:{2}:{3}",
                                               sMrchLogin, sOutSum, nInvId, sMrchPass1);
              
              // build CRC value
              MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
              byte[] bSignature = md5.ComputeHash(Encoding.ASCII.GetBytes(sCrcBase));
              
              StringBuilder sbSignature = new StringBuilder();
              foreach (byte b in bSignature)
                  sbSignature.AppendFormat("{0:x2}", b);
              
              string sCrc = sbSignature.ToString();
            
              // build URL
              /*LinkButtonPay = "https://auth.robokassa.ru/Merchant/Index.aspx?" +
                                                  "MerchantLogin=" + sMrchLogin +
                                                  "&OutSum=" + sOutSum +
                                                  "&InvId=" + nInvId +
                                                  "&Description=" + sDesc +
                                                  "&SignatureValue=" + sCrc;
                                                  */
                LinkButtonPay = "https://auth.robokassa.ru/Merchant/Index.aspx?MerchantLogin=demo&OutSum=11&Description=Покупка в демо магазине&SignatureValue=2c113e992e2c985e43e348ff3c12f32b&IsTest=IsTest";
            }
          }
