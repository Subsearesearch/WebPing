using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WebPing {
	public partial class frmWebPing : Form {
		private bool _StopPinging = false;
		private Timer _timer = new Timer();
		private Int64 _ctrPings = 1;

		public frmWebPing() {
			InitializeComponent();
		}

		private void frmWebPing_Load(object sender, EventArgs e) {
			txtURL.Text = ConfigurationManager.AppSettings.Get("defaultURL"); ;
			_timer.Tick += new EventHandler(TimerEventProcessor);
		}

		private void btnClose_Click(object sender, EventArgs e) {
			StopPinging();
			_timer.Dispose();
			Application.Exit();
		}

		private void frmWebPing_Shown(object sender, EventArgs e) {
			btnPing.Focus();
		}

		private void btnPing_Click(object sender, EventArgs e) {
			lstPings.Items.Clear();
			btnPing.Enabled = false;
			if (Convert.ToInt32(txtPingInterval.Text) < 5) txtPingInterval.Text = "5";

			if (Convert.ToInt64(txtPingCount.Text) > 0) {
				_timer.Interval = Convert.ToInt32(txtPingInterval.Text);
				_ctrPings = 1;
				_timer.Start();
			}
		}

		private void btnStopPinging_Click(object sender, EventArgs e) {
			StopPinging();
		}

		private void PingWebURL() {
			if (String.IsNullOrWhiteSpace(txtURL.Text)) MessageBox.Show("No URL Specified");
			if (txtURL.Text.Substring(0, 7) != "http://" && txtURL.Text.Substring(0, 8) != "https://") {
				txtURL.Text = "http://" + txtURL.Text;
			}
			if (String.IsNullOrWhiteSpace(txtTimeout.Text)) txtTimeout.Text = "5000";

			HttpWebRequest rqst = (HttpWebRequest)WebRequest.Create(txtURL.Text);
			rqst.Timeout = Convert.ToInt32(txtTimeout.Text);

			HttpWebResponse response = null;
			HttpStatusCode statusCodeHTTP;
			int statusCodeInt = 0;
			string statusCodeStr = "";
			try {
				response = (HttpWebResponse) rqst.GetResponse();
				statusCodeHTTP = response.StatusCode;
				statusCodeInt = (int) statusCodeHTTP;
				statusCodeStr = statusCodeHTTP.ToString();
			} catch (WebException we) {
				response = (HttpWebResponse) we.Response;
				StopPinging();
			}

			string responseStream;
			if (response == null) {
				responseStream = "Timeout occurred while waiting for a response.";
				statusCodeStr = "Response Timeout";
				statusCodeInt = 999;
				StopPinging();
			} else {
				responseStream = new StreamReader(response.GetResponseStream()).ReadToEnd();
				response.Close();
			}
			lstPings.Items.Add(_ctrPings.ToString() + " Status Code: " + statusCodeInt + " (" + statusCodeStr + ") " + responseStream.Substring(0, (responseStream.Length > 255) ? 255 : responseStream.Length));
		}

		private void TimerEventProcessor(object sender, EventArgs e) {
			if (_ctrPings > Convert.ToInt64(txtPingCount.Text) || _StopPinging) {
				StopPinging();
			} else {
				PingWebURL();
				_ctrPings++;
			}
		}

		private void StopPinging() {
			_StopPinging = true;
			if (_timer.Enabled) _timer.Stop();
			_StopPinging = false;
			btnPing.Enabled = true;
		}

		private void btnClear_Click(object sender, EventArgs e) {
			lstPings.Items.Clear();
		}
	}
}
