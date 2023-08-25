
namespace AMIS3.ZZ.AN.MU004
{
    partial class UserControl1
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.aSearchControl1 = new AMIS3.UIFramework.UI.Controls.ASearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.aSearchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // aSearchControl1
            // 
            this.aSearchControl1.FieldValue = "";
            this.aSearchControl1.Location = new System.Drawing.Point(3, 3);
            this.aSearchControl1.Name = "aSearchControl1";
            this.aSearchControl1.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.aSearchControl1.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aSearchControl1.Properties.Appearance.Options.UseBorderColor = true;
            this.aSearchControl1.Properties.Appearance.Options.UseFont = true;
            this.aSearchControl1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(177)))));
            this.aSearchControl1.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.aSearchControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.aSearchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.aSearchControl1.Properties.ShowClearButton = false;
            this.aSearchControl1.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            this.aSearchControl1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.aSearchControl1.Size = new System.Drawing.Size(100, 22);
            this.aSearchControl1.TabIndex = 1;
            this.aSearchControl1.Click += new System.EventHandler(this.aTextEdit1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aSearchControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(104, 28);
            this.Click += new System.EventHandler(this.aTextEdit1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.aSearchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIFramework.UI.Controls.ASearchControl aSearchControl1;
    }
}
