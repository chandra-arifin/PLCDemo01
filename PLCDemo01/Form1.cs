using dotPLC.Mitsubishi;

namespace PLCDemo01;

using ActUtlTypeLib;

public partial class Form1 : Form
{
    private ActUtlType plc = new();
    private Int16 stationNo;
    private int mode = 0;

    private bool isConnected = false;

    public Form1()
    {
        InitializeComponent();
    }

    //private void ConnectViaSerial()
    //{
    //    // Example: Write to a coil to control run/stop
    //    byte slaveId = 1; // Set this to your PLC's Modbus slave ID
    //    ushort coilAddress = 0; // Address of the coil to control run/stop

    //    // Configure the serial port
    //    SerialPort serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
    //    serialPort.Open();

    //    // Create a Modbus factory
    //    var factory = new ModbusFactory();
    //    var master = factory.CreateRtuMaster(serialPort);

    //    isConnected = btnConnect.Text == "Disconnect";
    //    try
    //    {
    //        if (!isConnected)
    //        {
    //            plc.Open();
    //            lblKoneksi.Text = "Connected";
    //            btnConnect.Text = "Disconnect";
    //        }
    //        else
    //        {
    //            plc.Close();
    //            lblKoneksi.Text = "Disconnect";
    //            btnConnect.Text = "Connect";
    //        }
    //    }
    //    catch (Exception exc)
    //    {
    //        MessageBox.Show(exc.Message);
    //    }


    //    serialPort.Close();
    //}

    private void ConnectViaTes()
    {
        
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
        //ConnectViaSerial();
        ConnectViaStation();
    }

    //private void RunStopPLCViaSerial()
    //{
    //    // Configure the serial port
    //    SerialPort serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
    //    serialPort.Open();

    //    // Create a Modbus factory
    //    var factory = new ModbusFactory();
    //    var master = factory.CreateRtuMaster(serialPort);

    //    // Example: Write to a coil to control run/stop
    //    byte slaveId = 1; // Set this to your PLC's Modbus slave ID
    //    ushort coilAddress = 0; // Address of the coil to control run/stop

    //    int isRun = (checkBox1.Checked ? 1 : 0);

    //    if (isRun == 1)
    //    {
    //        // To run the PLC
    //        master.WriteSingleCoil(slaveId, coilAddress, true);
    //        Console.WriteLine("PLC is set to RUN mode.");
    //    }
    //    else
    //    {
    //        // To stop the PLC
    //        master.WriteSingleCoil(slaveId, coilAddress, false);
    //        Console.WriteLine("PLC is set to STOP mode.");
    //    }

    //    // Close the serial port
    //    serialPort.Close();
    //}

    private void RunStopViaPLC()
    {
        mode = (checkBox1.Checked ? 1 : 0);
        plc.SetCpuStatus(mode);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        //RunStopPLCViaSerial();
        RunStopViaPLC();
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
