<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class artistOutputForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(artistOutputForm))
        Label2 = New Label()
        costs = New Label()
        Label7 = New Label()
        Label8 = New Label()
        lblTotalIncome = New Label()
        lblCost = New Label()
        lblProfit = New Label()
        lblConcertName = New Label()
        lblArtist = New Label()
        Label6 = New Label()
        Label9 = New Label()
        lblBookedSeats = New Label()
        Label10 = New Label()
        lblVenueCost = New Label()
        Label12 = New Label()
        Label13 = New Label()
        lblVenue = New Label()
        Label14 = New Label()
        lblConcertDate = New Label()
        Label16 = New Label()
        lblTicketPrice = New Label()
        Label18 = New Label()
        cmbConcertNames = New ComboBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Enabled = False
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(500, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 19)
        Label2.TabIndex = 11
        Label2.Text = "Concert Name:"
        ' 
        ' costs
        ' 
        costs.AutoSize = True
        costs.Enabled = False
        costs.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        costs.ForeColor = SystemColors.ActiveCaptionText
        costs.Location = New Point(673, 249)
        costs.Name = "costs"
        costs.Size = New Size(81, 19)
        costs.TabIndex = 15
        costs.Text = "INCOME:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Enabled = False
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(673, 372)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 19)
        Label7.TabIndex = 16
        Label7.Text = "Cost"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Enabled = False
        Label8.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(673, 536)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 19)
        Label8.TabIndex = 17
        Label8.Text = "Profit"
        ' 
        ' lblTotalIncome
        ' 
        lblTotalIncome.AutoSize = True
        lblTotalIncome.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        lblTotalIncome.Location = New Point(1058, 349)
        lblTotalIncome.Name = "lblTotalIncome"
        lblTotalIncome.Size = New Size(76, 23)
        lblTotalIncome.TabIndex = 18
        lblTotalIncome.Text = "Income"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        lblCost.ForeColor = Color.Red
        lblCost.Location = New Point(1058, 453)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(50, 23)
        lblCost.TabIndex = 19
        lblCost.Text = "Cost"
        ' 
        ' lblProfit
        ' 
        lblProfit.AutoSize = True
        lblProfit.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        lblProfit.Location = New Point(1058, 536)
        lblProfit.Name = "lblProfit"
        lblProfit.Size = New Size(58, 23)
        lblProfit.TabIndex = 20
        lblProfit.Text = "Profit"
        ' 
        ' lblConcertName
        ' 
        lblConcertName.AutoSize = True
        lblConcertName.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblConcertName.Location = New Point(618, 144)
        lblConcertName.Name = "lblConcertName"
        lblConcertName.Size = New Size(0, 19)
        lblConcertName.TabIndex = 21
        ' 
        ' lblArtist
        ' 
        lblArtist.AutoSize = True
        lblArtist.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblArtist.Location = New Point(1037, 147)
        lblArtist.Name = "lblArtist"
        lblArtist.Size = New Size(0, 19)
        lblArtist.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Enabled = False
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(919, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 19)
        Label6.TabIndex = 23
        Label6.Text = "Artist:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 11.25F)
        Label9.Location = New Point(673, 291)
        Label9.Name = "Label9"
        Label9.Size = New Size(171, 17)
        Label9.TabIndex = 25
        Label9.Text = "Number of Seats Booked"
        ' 
        ' lblBookedSeats
        ' 
        lblBookedSeats.AutoSize = True
        lblBookedSeats.Font = New Font("Arial", 12F)
        lblBookedSeats.Location = New Point(869, 291)
        lblBookedSeats.Name = "lblBookedSeats"
        lblBookedSeats.Size = New Size(0, 18)
        lblBookedSeats.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label10.Location = New Point(869, 345)
        Label10.Name = "Label10"
        Label10.Size = New Size(52, 19)
        Label10.TabIndex = 27
        Label10.Text = "Total:"
        ' 
        ' lblVenueCost
        ' 
        lblVenueCost.AutoSize = True
        lblVenueCost.Font = New Font("Arial", 12F)
        lblVenueCost.Location = New Point(878, 410)
        lblVenueCost.Name = "lblVenueCost"
        lblVenueCost.Size = New Size(0, 18)
        lblVenueCost.TabIndex = 29
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 11.25F)
        Label12.Location = New Point(673, 410)
        Label12.Name = "Label12"
        Label12.Size = New Size(121, 17)
        Label12.TabIndex = 28
        Label12.Text = "Venue Cost Price"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label13.Location = New Point(869, 457)
        Label13.Name = "Label13"
        Label13.Size = New Size(123, 19)
        Label13.TabIndex = 30
        Label13.Text = "Total Expense:"
        ' 
        ' lblVenue
        ' 
        lblVenue.AutoSize = True
        lblVenue.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblVenue.Location = New Point(618, 193)
        lblVenue.Name = "lblVenue"
        lblVenue.Size = New Size(0, 19)
        lblVenue.TabIndex = 33
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Enabled = False
        Label14.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(500, 190)
        Label14.Name = "Label14"
        Label14.Size = New Size(56, 19)
        Label14.TabIndex = 32
        Label14.Text = "Venue:"
        ' 
        ' lblConcertDate
        ' 
        lblConcertDate.AutoSize = True
        lblConcertDate.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblConcertDate.Location = New Point(1037, 192)
        lblConcertDate.Name = "lblConcertDate"
        lblConcertDate.Size = New Size(0, 19)
        lblConcertDate.TabIndex = 35
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Enabled = False
        Label16.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(919, 189)
        Label16.Name = "Label16"
        Label16.Size = New Size(104, 19)
        Label16.TabIndex = 34
        Label16.Text = "Concert Date:"
        ' 
        ' lblTicketPrice
        ' 
        lblTicketPrice.AutoSize = True
        lblTicketPrice.Font = New Font("Arial", 12F)
        lblTicketPrice.Location = New Point(869, 319)
        lblTicketPrice.Name = "lblTicketPrice"
        lblTicketPrice.Size = New Size(0, 18)
        lblTicketPrice.TabIndex = 37
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 11.25F)
        Label18.Location = New Point(673, 319)
        Label18.Name = "Label18"
        Label18.Size = New Size(107, 17)
        Label18.TabIndex = 36
        Label18.Text = "Price Per Seat:"
        ' 
        ' cmbConcertNames
        ' 
        cmbConcertNames.FormattingEnabled = True
        cmbConcertNames.Location = New Point(165, 29)
        cmbConcertNames.Margin = New Padding(3, 2, 3, 2)
        cmbConcertNames.Name = "cmbConcertNames"
        cmbConcertNames.Size = New Size(214, 27)
        cmbConcertNames.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Location = New Point(28, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 19)
        Label1.TabIndex = 1
        Label1.Text = "Concert Name:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cmbConcertNames)
        GroupBox1.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(28, 141)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(437, 94)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        GroupBox1.Text = "SEARCH BY:"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1172, 81)
        FlowLayoutPanel1.TabIndex = 38
        ' 
        ' PictureBox1
        ' 
        PictureBox1.AccessibleRole = AccessibleRole.None
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 78)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label3)
        FlowLayoutPanel2.Controls.Add(Label4)
        FlowLayoutPanel2.Location = New Point(110, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(675, 78)
        FlowLayoutPanel2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Enabled = False
        Label3.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(598, 41)
        Label3.TabIndex = 13
        Label3.Text = "CONCERT MANAGEMENT SYSTEM"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Enabled = False
        Label4.Font = New Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(3, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 32)
        Label4.TabIndex = 13
        Label4.Text = "By Fans, For Fans"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Enabled = False
        Label5.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(152, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(319, 29)
        Label5.TabIndex = 14
        Label5.Text = "ARTIST PROFIT ANALYSIS"
        ' 
        ' artistOutputForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PowderBlue
        ClientSize = New Size(1172, 728)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(lblTicketPrice)
        Controls.Add(Label5)
        Controls.Add(Label18)
        Controls.Add(lblConcertDate)
        Controls.Add(Label16)
        Controls.Add(lblVenue)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(lblVenueCost)
        Controls.Add(Label12)
        Controls.Add(Label10)
        Controls.Add(lblBookedSeats)
        Controls.Add(Label9)
        Controls.Add(lblArtist)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Controls.Add(lblConcertName)
        Controls.Add(lblProfit)
        Controls.Add(lblCost)
        Controls.Add(lblTotalIncome)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(costs)
        Controls.Add(Label2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "artistOutputForm"
        Text = "Artist Output"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents costs As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalIncome As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblProfit As Label
    Friend WithEvents lblConcertName As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBookedSeats As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblVenueCost As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblConcertDate As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblTicketPrice As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbConcertNames As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
