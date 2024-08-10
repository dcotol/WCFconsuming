using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace WCFConsuming
{
  public partial class WCFTestForm : Form
  {
    
    public WCFTestForm()
    {
      InitializeComponent();
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
      //WCFService.DTEServiceClient client = new WCFService.DTEServiceClient("BasicHttpBinding_IDTEService");
      //lblResponseMsg.Text = client.GetMessage(txtMessage.Text);

      //WcfHttpsServiceProxy.ServiceProxyClient client = new WcfHttpsServiceProxy.ServiceProxyClient("WSHttpBinding_IServiceProxy3");
      //lblResponseMsg.Text = client.GetMessage(txtMessage.Text);
      //"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImRjb3RvbGFyYUBnbWFpbC5jb20iLCJuYmYiOjE3MjMwNzk1NzgsImV4cCI6MTcyMzE2NTk3OCwiaWF0IjoxNzIzMDc5NTc4LCJpc3MiOiJJbm5vdmEiLCJhdWQiOiJGYWN0dXJlZCJ9.pnXw4rWXmfSWHdQJXpCaLrMWRdc5pOthhOMoaAIM92A"
//      "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImRjb3RvbGFyYUBnbWFpbC5jb20iLCJuYmYiOjE3MjMwODIwMDIsImV4cCI6MTcyMzE2ODQwMiwiaWF0IjoxNzIzMDgyMDAyLCJpc3MiOiJJbm5vdmEiLCJhdWQiOiJGYWN0dXJlZCJ9.UVJu5zfFFeRVDH6veCeR_aZQCVO0F-WqOF091izUxX4"

      String UrlBuild = $"https://localhost:8443/ServiceProxy/GetMessage";
      var client = new HttpClient();

      var request = new HttpRequestMessage(HttpMethod.Post, $"{UrlBuild}");
      //request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImRjb3RvbGFyYUBnbWFpbC5jb20iLCJuYmYiOjE3MjMxMTQ1ODMsImV4cCI6MTcyMzIwMDk4MywiaWF0IjoxNzIzMTE0NTgzLCJpc3MiOiJJbm5vdmEiLCJhdWQiOiJGYWN0dXJlZCJ9.vE3RTNPTPdJ18QPqyw1TBTT3ytnYmeEEFc1dIvTQKIk");

      request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("UserName", @"CLAVE-DELL13\Douglas");


      var newMessa = new MsgRequest();
      newMessa.Message = txtMessage.Text;

      string jsonContent = JsonConvert.SerializeObject(newMessa);


      StringContent content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");


      //StringContent content = new StringContent(txtMessage.Text);

      Task<HttpResponseMessage> responseTask = client.PostAsync(UrlBuild,content);

      // Wait for the response and read the content
      HttpResponseMessage response = responseTask.Result;
      string responseBody = response.Content.ReadAsStringAsync().Result;

      if (!String.IsNullOrEmpty(responseBody))
        lblResponseMsg.Text = responseBody;
      else
        lblResponseMsg.Text = responseTask.Result.StatusCode.ToString();
    }

    private void btnCustomer_Click(object sender, EventArgs e)
    {
      WCFService.DTEServiceClient client = new WCFService.DTEServiceClient("BasicHttpBinding_IDTEService");
      rchResponse.Text = client.GetCustomer();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      WCFService.DTEServiceClient client = new WCFService.DTEServiceClient("BasicHttpBinding_IDTEService");
      lblResponseUpdate.Text = client.UpdateCustomer(txtJson.Text);
      rchResponse.Text = client.GetCustomer(); // Updating the view
    }

    private void btnToken_Click(object sender, EventArgs e)
    {
      //WCFService.DTEServiceClient client = new WCFService.DTEServiceClient("BasicHttpBinding_IDTEService");
      //rchToken.Text = client.GetToken("{\"UserName\": \"dcotolara@gmail.com\", \"UserPassword\": \"Admin123@\"}");

      WcfHttpsServiceProxy.ServiceProxyClient client = new WcfHttpsServiceProxy.ServiceProxyClient("WSHttpBinding_IServiceProxy3");
      rchToken.Text = client.GetToken("{\"UserName\": \"dcotolara@gmail.com\", \"UserPassword\": \"Admin123@\"}");

    }

    public class MsgRequest
    {
      public String Message;
    }

  }

}
