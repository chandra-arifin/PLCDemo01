namespace PLCDemo01;

using ActUtlTypeLib;

public partial class Form2 : Form
{
    private ActUtlType plc = new();
    private Int16 stationNo;
    private int mode = 0;

    private bool isConnected = false;

    public Form2()
    {
        InitializeComponent();
    }

    private void ConnectViaStation()
    {
        stationNo = Convert.ToInt16(txtStationNo.Text);
        plc.ActLogicalStationNumber = stationNo;

        isConnected = btnConnect.Text == "Disconnect";
        try
        {
            if (!isConnected)
            {
                plc.Open();
                lblKoneksi.Text = "Connected";
                btnConnect.Text = "Disconnect";
            }
            else
            {
                plc.Close();
                lblKoneksi.Text = "Disconnect";
                btnConnect.Text = "Connect";
            }
        }
        catch (Exception exc)
        {
            MessageBox.Show(exc.Message);
        }


        plc.GetCpuType(out var type, out var code);

        lblCPUType2.Text = code.ToString();
        lblCPUType.Text = type;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        ConnectViaStation();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        mode = (checkBox1.Checked ? 1 : 0);
        plc.SetCpuStatus(mode);
    }

    private void chkPause_CheckedChanged(object sender, EventArgs e)
    {
        mode = (checkBox1.Checked ? 2 : 0);
        plc.SetCpuStatus(mode);

    }

    private void btnRead_Click(object sender, EventArgs e)
    {
        plc.GetDevice(txtVariable.Text, out var value);

        //plc.ReadDeviceBlock(txtVariable.Text, 1, out var value);
        txtHasil.Text = value.ToString();
    }

    private void btnWrite_Click(object sender, EventArgs e)
    {
        plc.SetDevice(txtVariable.Text, Convert.ToInt16(txtHasil.Text));

    }

    private void btnUpload_Click(object sender, EventArgs e)
    {


    }
}
