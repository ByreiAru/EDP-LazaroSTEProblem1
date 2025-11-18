<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TBArtworkTitle = New System.Windows.Forms.TextBox()
        Me.ArtistName = New System.Windows.Forms.TextBox()
        Me.ArtworkPrice = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.AddArtwork = New System.Windows.Forms.Button()
        Me.AnalyzeExhibit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ResetData = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Exhibit = New System.Windows.Forms.ListBox()
        Me.Outputs = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBArtworkTitle
        '
        Me.TBArtworkTitle.Location = New System.Drawing.Point(3, 153)
        Me.TBArtworkTitle.Name = "TBArtworkTitle"
        Me.TBArtworkTitle.Size = New System.Drawing.Size(78, 20)
        Me.TBArtworkTitle.TabIndex = 0
        '
        'ArtistName
        '
        Me.ArtistName.Location = New System.Drawing.Point(87, 153)
        Me.ArtistName.Name = "ArtistName"
        Me.ArtistName.Size = New System.Drawing.Size(78, 20)
        Me.ArtistName.TabIndex = 1
        '
        'ArtworkPrice
        '
        Me.ArtworkPrice.Location = New System.Drawing.Point(171, 153)
        Me.ArtworkPrice.Name = "ArtworkPrice"
        Me.ArtworkPrice.Size = New System.Drawing.Size(78, 20)
        Me.ArtworkPrice.TabIndex = 2
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"Painting", "Sculpture", "Digital Art", "Photography", "Crafts", " "})
        Me.CategoryComboBox.Location = New System.Drawing.Point(255, 153)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(120, 21)
        Me.CategoryComboBox.TabIndex = 3
        '
        'AddArtwork
        '
        Me.AddArtwork.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddArtwork.Location = New System.Drawing.Point(3, 303)
        Me.AddArtwork.Name = "AddArtwork"
        Me.AddArtwork.Size = New System.Drawing.Size(78, 144)
        Me.AddArtwork.TabIndex = 4
        Me.AddArtwork.Text = "Add Artwork"
        Me.AddArtwork.UseVisualStyleBackColor = True
        '
        'AnalyzeExhibit
        '
        Me.AnalyzeExhibit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnalyzeExhibit.Location = New System.Drawing.Point(381, 303)
        Me.AnalyzeExhibit.Name = "AnalyzeExhibit"
        Me.AnalyzeExhibit.Size = New System.Drawing.Size(279, 144)
        Me.AnalyzeExhibit.TabIndex = 5
        Me.AnalyzeExhibit.Text = "Analyze Exhibit"
        Me.AnalyzeExhibit.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.58245!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.58245!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.58245!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.87368!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71577!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6632!))
        Me.TableLayoutPanel1.Controls.Add(Me.ResetData, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TBArtworkTitle, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ArtistName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ArtworkPrice, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AddArtwork, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CategoryComboBox, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AnalyzeExhibit, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Exhibit, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Outputs, 5, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'ResetData
        '
        Me.ResetData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResetData.Location = New System.Drawing.Point(87, 303)
        Me.ResetData.Name = "ResetData"
        Me.ResetData.Size = New System.Drawing.Size(78, 144)
        Me.ResetData.TabIndex = 11
        Me.ResetData.Text = "Reset Data"
        Me.ResetData.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(171, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Price"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(87, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Artist"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(3, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Artwork Title"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Location = New System.Drawing.Point(255, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Category"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Exhibit
        '
        Me.Exhibit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Exhibit.FormattingEnabled = True
        Me.Exhibit.Location = New System.Drawing.Point(381, 3)
        Me.Exhibit.Name = "Exhibit"
        Me.TableLayoutPanel1.SetRowSpan(Me.Exhibit, 2)
        Me.Exhibit.Size = New System.Drawing.Size(279, 294)
        Me.Exhibit.TabIndex = 12
        '
        'Outputs
        '
        Me.Outputs.AutoSize = True
        Me.Outputs.Location = New System.Drawing.Point(666, 0)
        Me.Outputs.Name = "Outputs"
        Me.Outputs.Size = New System.Drawing.Size(52, 13)
        Me.Outputs.TabIndex = 13
        Me.Outputs.Text = "OUTPUT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBArtworkTitle As TextBox
    Friend WithEvents ArtistName As TextBox
    Friend WithEvents ArtworkPrice As TextBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents AddArtwork As Button
    Friend WithEvents AnalyzeExhibit As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ResetData As Button
    Friend WithEvents Exhibit As ListBox
    Friend WithEvents Outputs As Label
End Class
