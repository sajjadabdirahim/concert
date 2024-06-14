<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venueBookingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(venueBookingForm))
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        submitBtn = New Button()
        Name = New Label()
        txtConcertName = New TextBox()
        Label5 = New Label()
        txtTicketPrice = New TextBox()
        Label6 = New Label()
        cmboxVenue = New ComboBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(370, 279)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(219, 23)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        Label3.Location = New Point(110, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 20)
        Label3.TabIndex = 5
        Label3.Text = "Date:"
        ' 
        ' submitBtn
        ' 
        submitBtn.BackColor = Color.DeepSkyBlue
        submitBtn.FlatAppearance.BorderSize = 0
        submitBtn.FlatStyle = FlatStyle.Flat
        submitBtn.Location = New Point(308, 329)
        submitBtn.Margin = New Padding(3, 2, 3, 2)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(107, 47)
        submitBtn.TabIndex = 6
        submitBtn.Text = "Submit"
        submitBtn.UseVisualStyleBackColor = False
        ' 
        ' Name
        ' 
        Name.AutoSize = True
        Name.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        Name.Location = New Point(110, 146)
        Name.Name = "Name"
        Name.Size = New Size(100, 20)
        Name.TabIndex = 7
        Name.Text = "Concert Name:"
        ' 
        ' txtConcertName
        ' 
        txtConcertName.Location = New Point(370, 146)
        txtConcertName.Margin = New Padding(3, 2, 3, 2)
        txtConcertName.Name = "txtConcertName"
        txtConcertName.ShortcutsEnabled = False
        txtConcertName.Size = New Size(219, 23)
        txtConcertName.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        Label5.Location = New Point(110, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 20)
        Label5.TabIndex = 11
        Label5.Text = "Venue:"
        ' 
        ' txtTicketPrice
        ' 
        txtTicketPrice.Location = New Point(370, 228)
        txtTicketPrice.Margin = New Padding(3, 2, 3, 2)
        txtTicketPrice.Name = "txtTicketPrice"
        txtTicketPrice.ShortcutsEnabled = False
        txtTicketPrice.Size = New Size(219, 23)
        txtTicketPrice.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        Label6.Location = New Point(110, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 13
        Label6.Text = "Ticket Price:"
        ' 
        ' cmboxVenue
        ' 
        cmboxVenue.FormattingEnabled = True
        cmboxVenue.Location = New Point(370, 188)
        cmboxVenue.Name = "cmboxVenue"
        cmboxVenue.Size = New Size(219, 23)
        cmboxVenue.TabIndex = 2
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(770, 94)
        FlowLayoutPanel1.TabIndex = 16
        ' 
        ' PictureBox1
        ' 
        PictureBox1.AccessibleRole = AccessibleRole.None
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 91)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Controls.Add(Label2)
        FlowLayoutPanel2.Location = New Point(110, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(627, 91)
        FlowLayoutPanel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(505, 42)
        Label1.TabIndex = 13
        Label1.Text = "CONCERT MANAGEMENT SYSTEM"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Enabled = False
        Label2.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(3, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 22)
        Label2.TabIndex = 13
        Label2.Text = "By Fans, For Fans"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Enabled = False
        Label4.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(265, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 20)
        Label4.TabIndex = 14
        Label4.Text = "Book For A Venue:"
        ' 
        ' venueBookingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PowderBlue
        ClientSize = New Size(770, 387)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(cmboxVenue)
        Controls.Add(Label4)
        Controls.Add(txtTicketPrice)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtConcertName)
        Controls.Add(Name)
        Controls.Add(submitBtn)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        MaximizeBox = False
        MinimizeBox = False
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Artist input"
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents submitBtn As Button
    Friend WithEvents Name As Label
    Friend WithEvents txtConcertName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTicketPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmboxVenue As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
