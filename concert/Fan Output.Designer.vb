<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticketForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ticketForm))
        ticketBox = New GroupBox()
        lblTotalPrice = New Label()
        Label8 = New Label()
        lblConcertDate = New Label()
        Label9 = New Label()
        lblTicketID = New Label()
        lblVenue = New Label()
        lblPrice = New Label()
        lblSeats = New Label()
        lblConcertName = New Label()
        lblName = New Label()
        PictureBox2 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        ticketBox.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ticketBox
        ' 
        ticketBox.BackColor = Color.Black
        ticketBox.Controls.Add(lblTotalPrice)
        ticketBox.Controls.Add(Label8)
        ticketBox.Controls.Add(lblConcertDate)
        ticketBox.Controls.Add(Label9)
        ticketBox.Controls.Add(lblTicketID)
        ticketBox.Controls.Add(lblVenue)
        ticketBox.Controls.Add(lblPrice)
        ticketBox.Controls.Add(lblSeats)
        ticketBox.Controls.Add(lblConcertName)
        ticketBox.Controls.Add(lblName)
        ticketBox.Controls.Add(PictureBox2)
        ticketBox.Controls.Add(Label7)
        ticketBox.Controls.Add(Label6)
        ticketBox.Controls.Add(Label5)
        ticketBox.Controls.Add(Label4)
        ticketBox.Controls.Add(Label3)
        ticketBox.Controls.Add(Label2)
        ticketBox.Controls.Add(Label1)
        ticketBox.Controls.Add(GroupBox2)
        ticketBox.ForeColor = Color.White
        ticketBox.Location = New Point(73, 43)
        ticketBox.Margin = New Padding(3, 2, 3, 2)
        ticketBox.Name = "ticketBox"
        ticketBox.Padding = New Padding(3, 2, 3, 2)
        ticketBox.Size = New Size(1029, 252)
        ticketBox.TabIndex = 0
        ticketBox.TabStop = False
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.AutoSize = True
        lblTotalPrice.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        lblTotalPrice.Location = New Point(344, 189)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(126, 20)
        lblTotalPrice.TabIndex = 24
        lblTotalPrice.Text = "Total price amount"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label8.Location = New Point(239, 189)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 19)
        Label8.TabIndex = 23
        Label8.Text = "Total Price:"
        ' 
        ' lblConcertDate
        ' 
        lblConcertDate.AutoSize = True
        lblConcertDate.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConcertDate.Location = New Point(580, 219)
        lblConcertDate.Name = "lblConcertDate"
        lblConcertDate.Size = New Size(184, 20)
        lblConcertDate.TabIndex = 22
        lblConcertDate.Text = "concert date to be displayed"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label9.Location = New Point(480, 220)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 19)
        Label9.TabIndex = 21
        Label9.Text = "Concert Date: "
        ' 
        ' lblTicketID
        ' 
        lblTicketID.AutoSize = True
        lblTicketID.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        lblTicketID.Location = New Point(621, 17)
        lblTicketID.Name = "lblTicketID"
        lblTicketID.Size = New Size(67, 20)
        lblTicketID.TabIndex = 20
        lblTicketID.Text = "Ticket ID "
        ' 
        ' lblVenue
        ' 
        lblVenue.AutoSize = True
        lblVenue.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        lblVenue.Location = New Point(344, 92)
        lblVenue.Name = "lblVenue"
        lblVenue.Size = New Size(147, 20)
        lblVenue.TabIndex = 19
        lblVenue.Text = "Venue to be displayed"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        lblPrice.Location = New Point(344, 154)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(425, 20)
        lblPrice.TabIndex = 18
        lblPrice.Text = "Price to be displayed and calculate by unit price *  number of seats"
        ' 
        ' lblSeats
        ' 
        lblSeats.AutoSize = True
        lblSeats.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        lblSeats.Location = New Point(344, 120)
        lblSeats.Name = "lblSeats"
        lblSeats.Size = New Size(0, 20)
        lblSeats.TabIndex = 17
        ' 
        ' lblConcertName
        ' 
        lblConcertName.AutoSize = True
        lblConcertName.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        lblConcertName.Location = New Point(344, 59)
        lblConcertName.Name = "lblConcertName"
        lblConcertName.Size = New Size(210, 20)
        lblConcertName.TabIndex = 16
        lblConcertName.Text = "Concert Name is to be displayed"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        lblName.Location = New Point(344, 22)
        lblName.Name = "lblName"
        lblName.Size = New Size(185, 20)
        lblName.TabIndex = 15
        lblName.Text = "Fan Name is to be displayed"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Location = New Point(778, 0)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(251, 252)
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label7.Location = New Point(694, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 19)
        Label7.TabIndex = 13
        Label7.Text = "Ticket Id"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label6.Location = New Point(239, 91)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 19)
        Label6.TabIndex = 11
        Label6.Text = "Venue:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        Label5.Location = New Point(554, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label4.Location = New Point(239, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 19)
        Label4.TabIndex = 9
        Label4.Text = "Price:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(239, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 19)
        Label3.TabIndex = 8
        Label3.Text = "Seats:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        Label2.Location = New Point(239, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 7
        Label2.Text = "Concert Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label1.Location = New Point(239, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 19)
        Label1.TabIndex = 6
        Label1.Text = "Name:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(206, 230)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(206, 252)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ticketForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PowderBlue
        ClientSize = New Size(1132, 338)
        Controls.Add(ticketBox)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ticketForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ticket"
        ticketBox.ResumeLayout(False)
        ticketBox.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ticketBox As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtConcertName As TextBox
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtVenue As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTicketID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblSeats As Label
    Friend WithEvents lblConcertName As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblTicketID As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblConcertDate As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents Label8 As Label
End Class
