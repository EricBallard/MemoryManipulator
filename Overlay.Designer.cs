
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryManipulator
{
    partial class Overlay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.npcLbl = new System.Windows.Forms.Label();
            this.itemGroup = new System.Windows.Forms.GroupBox();
            this.curPage = new System.Windows.Forms.Label();
            this.itemPage2 = new System.Windows.Forms.GroupBox();
            this.accesoryValue = new System.Windows.Forms.CheckBox();
            this.rangedValue = new System.Windows.Forms.CheckBox();
            this.magicValue = new System.Windows.Forms.CheckBox();
            this.projectileValue = new System.Windows.Forms.NumericUpDown();
            this.noMeleeValue = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.meleeValue = new System.Windows.Forms.CheckBox();
            this.wandValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tileValue = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.wallValue = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.headValue = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.bodyValue = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.legValue = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.ammoSpeedValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ammoValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nxtPage = new System.Windows.Forms.Button();
            this.itemPage1 = new System.Windows.Forms.GroupBox();
            this.reuseValue = new System.Windows.Forms.CheckBox();
            this.label43 = new System.Windows.Forms.Label();
            this.hammerValue = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.pickValue = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.axeValue = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.maxStackValue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.shinyValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.typeValue = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.scaleValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.useValue = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.stackValue = new System.Windows.Forms.NumericUpDown();
            this.rangeValue = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.delayValue = new System.Windows.Forms.NumericUpDown();
            this.knockValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.damageValue = new System.Windows.Forms.NumericUpDown();
            this.itemList = new System.Windows.Forms.LinkLabel();
            this.editItemLbl = new System.Windows.Forms.Label();
            this.applyItem = new System.Windows.Forms.Button();
            this.itemLbl = new System.Windows.Forms.Label();
            this.playerLbl = new System.Windows.Forms.Label();
            this.ldLbl = new System.Windows.Forms.Label();
            this.loadProgress = new System.Windows.Forms.ProgressBar();
            this.npcGroup = new System.Windows.Forms.GroupBox();
            this.applyNpc = new System.Windows.Forms.Button();
            this.npcLink = new System.Windows.Forms.LinkLabel();
            this.npcDetailGroup = new System.Windows.Forms.GroupBox();
            this.isFriendly = new System.Windows.Forms.CheckBox();
            this.noGravity = new System.Windows.Forms.CheckBox();
            this.closeDoors = new System.Windows.Forms.CheckBox();
            this.isInvincible = new System.Windows.Forms.CheckBox();
            this.noColliision = new System.Windows.Forms.CheckBox();
            this.npcDamage = new System.Windows.Forms.NumericUpDown();
            this.npcStyle = new System.Windows.Forms.NumericUpDown();
            this.npcLife = new System.Windows.Forms.NumericUpDown();
            this.npcMax = new System.Windows.Forms.NumericUpDown();
            this.npcSpeed = new System.Windows.Forms.NumericUpDown();
            this.npcType = new System.Windows.Forms.NumericUpDown();
            this.npcBoss = new System.Windows.Forms.NumericUpDown();
            this.npcTown = new System.Windows.Forms.NumericUpDown();
            this.npcScale = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.refreshList = new System.Windows.Forms.Button();
            this.npcList = new System.Windows.Forms.ListBox();
            this.playerGroup = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.difficultyValue = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.dragValue = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.accelerationValue = new System.Windows.Forms.NumericUpDown();
            this.maxSpeedValue = new System.Windows.Forms.NumericUpDown();
            this.gravityValue = new System.Windows.Forms.NumericUpDown();
            this.maxBreathValue = new System.Windows.Forms.NumericUpDown();
            this.maxManaValue = new System.Windows.Forms.NumericUpDown();
            this.maxLifeValue = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.applyPlayer = new System.Windows.Forms.Button();
            this.jumpsValue = new System.Windows.Forms.CheckBox();
            this.killsValue = new System.Windows.Forms.CheckBox();
            this.itemsValue = new System.Windows.Forms.CheckBox();
            this.godValue = new System.Windows.Forms.CheckBox();
            this.itemGroup.SuspendLayout();
            this.itemPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectileValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wandValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoSpeedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoValue)).BeginInit();
            this.itemPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hammerValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxStackValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shinyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knockValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageValue)).BeginInit();
            this.npcGroup.SuspendLayout();
            this.npcDetailGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcScale)).BeginInit();
            this.playerGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerationValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBreathValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxManaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLifeValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // npcLbl
            // 
            this.npcLbl.AutoSize = true;
            this.npcLbl.BackColor = System.Drawing.Color.DimGray;
            this.npcLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.npcLbl.ForeColor = System.Drawing.Color.Black;
            this.npcLbl.Location = new System.Drawing.Point(13, 48);
            this.npcLbl.Name = "npcLbl";
            this.npcLbl.Size = new System.Drawing.Size(79, 15);
            this.npcLbl.TabIndex = 1;
            this.npcLbl.Tag = "";
            this.npcLbl.Text = "[3] EDIT NPC";
            this.npcLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.npcLbl.Visible = false;
            // 
            // itemGroup
            // 
            this.itemGroup.BackColor = System.Drawing.Color.Gray;
            this.itemGroup.Controls.Add(this.curPage);
            this.itemGroup.Controls.Add(this.itemPage2);
            this.itemGroup.Controls.Add(this.nxtPage);
            this.itemGroup.Controls.Add(this.itemPage1);
            this.itemGroup.Controls.Add(this.itemList);
            this.itemGroup.Controls.Add(this.editItemLbl);
            this.itemGroup.Controls.Add(this.applyItem);
            this.itemGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.itemGroup.Location = new System.Drawing.Point(13, 96);
            this.itemGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemGroup.Name = "itemGroup";
            this.itemGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemGroup.Size = new System.Drawing.Size(181, 517);
            this.itemGroup.TabIndex = 4;
            this.itemGroup.TabStop = false;
            this.itemGroup.Text = "Edit Item";
            this.itemGroup.Visible = false;
            // 
            // curPage
            // 
            this.curPage.AutoSize = true;
            this.curPage.Location = new System.Drawing.Point(12, 465);
            this.curPage.Name = "curPage";
            this.curPage.Size = new System.Drawing.Size(24, 15);
            this.curPage.TabIndex = 68;
            this.curPage.Text = "1/2";
            // 
            // itemPage2
            // 
            this.itemPage2.BackColor = System.Drawing.Color.Gray;
            this.itemPage2.Controls.Add(this.accesoryValue);
            this.itemPage2.Controls.Add(this.rangedValue);
            this.itemPage2.Controls.Add(this.magicValue);
            this.itemPage2.Controls.Add(this.projectileValue);
            this.itemPage2.Controls.Add(this.noMeleeValue);
            this.itemPage2.Controls.Add(this.label31);
            this.itemPage2.Controls.Add(this.meleeValue);
            this.itemPage2.Controls.Add(this.wandValue);
            this.itemPage2.Controls.Add(this.label8);
            this.itemPage2.Controls.Add(this.tileValue);
            this.itemPage2.Controls.Add(this.label9);
            this.itemPage2.Controls.Add(this.wallValue);
            this.itemPage2.Controls.Add(this.label10);
            this.itemPage2.Controls.Add(this.headValue);
            this.itemPage2.Controls.Add(this.label23);
            this.itemPage2.Controls.Add(this.bodyValue);
            this.itemPage2.Controls.Add(this.label24);
            this.itemPage2.Controls.Add(this.legValue);
            this.itemPage2.Controls.Add(this.label25);
            this.itemPage2.Controls.Add(this.ammoSpeedValue);
            this.itemPage2.Controls.Add(this.label5);
            this.itemPage2.Controls.Add(this.ammoValue);
            this.itemPage2.Controls.Add(this.label2);
            this.itemPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.itemPage2.Location = new System.Drawing.Point(6, 51);
            this.itemPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemPage2.Name = "itemPage2";
            this.itemPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemPage2.Size = new System.Drawing.Size(169, 425);
            this.itemPage2.TabIndex = 11;
            this.itemPage2.TabStop = false;
            this.itemPage2.Visible = false;
            // 
            // accesoryValue
            // 
            this.accesoryValue.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accesoryValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.accesoryValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accesoryValue.Location = new System.Drawing.Point(12, 183);
            this.accesoryValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accesoryValue.Name = "accesoryValue";
            this.accesoryValue.Size = new System.Drawing.Size(159, 23);
            this.accesoryValue.TabIndex = 68;
            this.accesoryValue.Text = "Accesory:";
            this.accesoryValue.UseVisualStyleBackColor = true;
            // 
            // rangedValue
            // 
            this.rangedValue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rangedValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.rangedValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rangedValue.Location = new System.Drawing.Point(80, 277);
            this.rangedValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rangedValue.Name = "rangedValue";
            this.rangedValue.Size = new System.Drawing.Size(85, 41);
            this.rangedValue.TabIndex = 49;
            this.rangedValue.Text = "Ranged";
            this.rangedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rangedValue.UseVisualStyleBackColor = true;
            // 
            // magicValue
            // 
            this.magicValue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.magicValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.magicValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.magicValue.Location = new System.Drawing.Point(5, 277);
            this.magicValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.magicValue.Name = "magicValue";
            this.magicValue.Size = new System.Drawing.Size(85, 41);
            this.magicValue.TabIndex = 48;
            this.magicValue.Text = "Magic";
            this.magicValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.magicValue.UseVisualStyleBackColor = true;
            // 
            // projectileValue
            // 
            this.projectileValue.BackColor = System.Drawing.Color.DarkGray;
            this.projectileValue.Enabled = false;
            this.projectileValue.Location = new System.Drawing.Point(85, 329);
            this.projectileValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectileValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.projectileValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.projectileValue.Name = "projectileValue";
            this.projectileValue.Size = new System.Drawing.Size(80, 23);
            this.projectileValue.TabIndex = 57;
            this.projectileValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.projectileValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // noMeleeValue
            // 
            this.noMeleeValue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noMeleeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.noMeleeValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noMeleeValue.Location = new System.Drawing.Point(5, 230);
            this.noMeleeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noMeleeValue.Name = "noMeleeValue";
            this.noMeleeValue.Size = new System.Drawing.Size(85, 41);
            this.noMeleeValue.TabIndex = 47;
            this.noMeleeValue.Text = "No Melee";
            this.noMeleeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noMeleeValue.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.Enabled = false;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label31.Location = new System.Drawing.Point(6, 333);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(68, 23);
            this.label31.TabIndex = 58;
            this.label31.Text = "Projectile Type:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // meleeValue
            // 
            this.meleeValue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.meleeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.meleeValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.meleeValue.Location = new System.Drawing.Point(80, 230);
            this.meleeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.meleeValue.Name = "meleeValue";
            this.meleeValue.Size = new System.Drawing.Size(85, 41);
            this.meleeValue.TabIndex = 46;
            this.meleeValue.Text = "Melee";
            this.meleeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.meleeValue.UseVisualStyleBackColor = true;
            // 
            // wandValue
            // 
            this.wandValue.BackColor = System.Drawing.Color.DarkGray;
            this.wandValue.Location = new System.Drawing.Point(85, 21);
            this.wandValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wandValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.wandValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.wandValue.Name = "wandValue";
            this.wandValue.Size = new System.Drawing.Size(80, 23);
            this.wandValue.TabIndex = 51;
            this.wandValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wandValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label8.Location = new System.Drawing.Point(5, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 52;
            this.label8.Text = "Tile Wand:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tileValue
            // 
            this.tileValue.BackColor = System.Drawing.Color.DarkGray;
            this.tileValue.Location = new System.Drawing.Point(85, 48);
            this.tileValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tileValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tileValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.tileValue.Name = "tileValue";
            this.tileValue.Size = new System.Drawing.Size(80, 23);
            this.tileValue.TabIndex = 53;
            this.tileValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tileValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label9.Location = new System.Drawing.Point(10, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "Create Tile:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wallValue
            // 
            this.wallValue.BackColor = System.Drawing.Color.DarkGray;
            this.wallValue.Location = new System.Drawing.Point(85, 75);
            this.wallValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wallValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.wallValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.wallValue.Name = "wallValue";
            this.wallValue.Size = new System.Drawing.Size(80, 23);
            this.wallValue.TabIndex = 55;
            this.wallValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wallValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label10.Location = new System.Drawing.Point(10, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 23);
            this.label10.TabIndex = 56;
            this.label10.Text = "Create Wall:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // headValue
            // 
            this.headValue.BackColor = System.Drawing.Color.DarkGray;
            this.headValue.Location = new System.Drawing.Point(85, 102);
            this.headValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.headValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.headValue.Name = "headValue";
            this.headValue.Size = new System.Drawing.Size(80, 23);
            this.headValue.TabIndex = 37;
            this.headValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.headValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label23.Location = new System.Drawing.Point(10, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 23);
            this.label23.TabIndex = 38;
            this.label23.Text = "Head Slot:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bodyValue
            // 
            this.bodyValue.BackColor = System.Drawing.Color.DarkGray;
            this.bodyValue.Location = new System.Drawing.Point(85, 129);
            this.bodyValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bodyValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bodyValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.bodyValue.Name = "bodyValue";
            this.bodyValue.Size = new System.Drawing.Size(80, 23);
            this.bodyValue.TabIndex = 39;
            this.bodyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bodyValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label24.Location = new System.Drawing.Point(10, 129);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 23);
            this.label24.TabIndex = 40;
            this.label24.Text = "Body Slot:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // legValue
            // 
            this.legValue.BackColor = System.Drawing.Color.DarkGray;
            this.legValue.Location = new System.Drawing.Point(85, 156);
            this.legValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.legValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.legValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.legValue.Name = "legValue";
            this.legValue.Size = new System.Drawing.Size(80, 23);
            this.legValue.TabIndex = 41;
            this.legValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.legValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label25.Location = new System.Drawing.Point(10, 156);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 23);
            this.label25.TabIndex = 42;
            this.label25.Text = "Leg Slot:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ammoSpeedValue
            // 
            this.ammoSpeedValue.BackColor = System.Drawing.Color.DarkGray;
            this.ammoSpeedValue.Enabled = false;
            this.ammoSpeedValue.Location = new System.Drawing.Point(85, 358);
            this.ammoSpeedValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ammoSpeedValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ammoSpeedValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ammoSpeedValue.Name = "ammoSpeedValue";
            this.ammoSpeedValue.Size = new System.Drawing.Size(80, 23);
            this.ammoSpeedValue.TabIndex = 24;
            this.ammoSpeedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ammoSpeedValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label5.Location = new System.Drawing.Point(10, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Shoot Speed:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ammoValue
            // 
            this.ammoValue.BackColor = System.Drawing.Color.DarkGray;
            this.ammoValue.Enabled = false;
            this.ammoValue.Location = new System.Drawing.Point(85, 385);
            this.ammoValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ammoValue.Maximum = new decimal(new int[] {
            5078,
            0,
            0,
            0});
            this.ammoValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ammoValue.Name = "ammoValue";
            this.ammoValue.Size = new System.Drawing.Size(80, 23);
            this.ammoValue.TabIndex = 22;
            this.ammoValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ammoValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label2.Location = new System.Drawing.Point(6, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ammo Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nxtPage
            // 
            this.nxtPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.nxtPage.Location = new System.Drawing.Point(6, 490);
            this.nxtPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nxtPage.Name = "nxtPage";
            this.nxtPage.Size = new System.Drawing.Size(40, 22);
            this.nxtPage.TabIndex = 50;
            this.nxtPage.Text = ">>";
            this.nxtPage.UseVisualStyleBackColor = true;
            this.nxtPage.Click += new System.EventHandler(this.nxtPage_Click);
            // 
            // itemPage1
            // 
            this.itemPage1.Controls.Add(this.reuseValue);
            this.itemPage1.Controls.Add(this.label43);
            this.itemPage1.Controls.Add(this.hammerValue);
            this.itemPage1.Controls.Add(this.label32);
            this.itemPage1.Controls.Add(this.pickValue);
            this.itemPage1.Controls.Add(this.label30);
            this.itemPage1.Controls.Add(this.axeValue);
            this.itemPage1.Controls.Add(this.label33);
            this.itemPage1.Controls.Add(this.maxStackValue);
            this.itemPage1.Controls.Add(this.label7);
            this.itemPage1.Controls.Add(this.shinyValue);
            this.itemPage1.Controls.Add(this.label1);
            this.itemPage1.Controls.Add(this.typeValue);
            this.itemPage1.Controls.Add(this.label11);
            this.itemPage1.Controls.Add(this.scaleValue);
            this.itemPage1.Controls.Add(this.label6);
            this.itemPage1.Controls.Add(this.useValue);
            this.itemPage1.Controls.Add(this.label28);
            this.itemPage1.Controls.Add(this.stackValue);
            this.itemPage1.Controls.Add(this.rangeValue);
            this.itemPage1.Controls.Add(this.label12);
            this.itemPage1.Controls.Add(this.label29);
            this.itemPage1.Controls.Add(this.delayValue);
            this.itemPage1.Controls.Add(this.knockValue);
            this.itemPage1.Controls.Add(this.label4);
            this.itemPage1.Controls.Add(this.label3);
            this.itemPage1.Controls.Add(this.damageValue);
            this.itemPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemPage1.Location = new System.Drawing.Point(6, 51);
            this.itemPage1.Name = "itemPage1";
            this.itemPage1.Size = new System.Drawing.Size(169, 425);
            this.itemPage1.TabIndex = 13;
            this.itemPage1.TabStop = false;
            this.itemPage1.Enter += new System.EventHandler(this.itemPage1_Enter);
            // 
            // reuseValue
            // 
            this.reuseValue.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reuseValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.reuseValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reuseValue.Location = new System.Drawing.Point(5, 168);
            this.reuseValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reuseValue.Name = "reuseValue";
            this.reuseValue.Size = new System.Drawing.Size(172, 23);
            this.reuseValue.TabIndex = 59;
            this.reuseValue.Text = "Auto Reuse: ";
            this.reuseValue.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label43.Location = new System.Drawing.Point(2, 385);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(72, 23);
            this.label43.TabIndex = 67;
            this.label43.Text = "Hammer:";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hammerValue
            // 
            this.hammerValue.BackColor = System.Drawing.Color.DarkGray;
            this.hammerValue.Location = new System.Drawing.Point(85, 385);
            this.hammerValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hammerValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.hammerValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.hammerValue.Name = "hammerValue";
            this.hammerValue.Size = new System.Drawing.Size(80, 23);
            this.hammerValue.TabIndex = 66;
            this.hammerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hammerValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label32.Location = new System.Drawing.Point(2, 358);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 23);
            this.label32.TabIndex = 65;
            this.label32.Text = "Pickaxe:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pickValue
            // 
            this.pickValue.BackColor = System.Drawing.Color.DarkGray;
            this.pickValue.Location = new System.Drawing.Point(85, 358);
            this.pickValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.pickValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.pickValue.Name = "pickValue";
            this.pickValue.Size = new System.Drawing.Size(80, 23);
            this.pickValue.TabIndex = 64;
            this.pickValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pickValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label30.Location = new System.Drawing.Point(2, 331);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 23);
            this.label30.TabIndex = 63;
            this.label30.Text = "Axe:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // axeValue
            // 
            this.axeValue.BackColor = System.Drawing.Color.DarkGray;
            this.axeValue.Location = new System.Drawing.Point(85, 331);
            this.axeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axeValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.axeValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.axeValue.Name = "axeValue";
            this.axeValue.Size = new System.Drawing.Size(80, 23);
            this.axeValue.TabIndex = 62;
            this.axeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.axeValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label33.Location = new System.Drawing.Point(2, 101);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(72, 23);
            this.label33.TabIndex = 59;
            this.label33.Text = "Max Stack:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxStackValue
            // 
            this.maxStackValue.BackColor = System.Drawing.Color.DarkGray;
            this.maxStackValue.Location = new System.Drawing.Point(85, 101);
            this.maxStackValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxStackValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxStackValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.maxStackValue.Name = "maxStackValue";
            this.maxStackValue.Size = new System.Drawing.Size(80, 23);
            this.maxStackValue.TabIndex = 58;
            this.maxStackValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxStackValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label7.Location = new System.Drawing.Point(2, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Shiny:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shinyValue
            // 
            this.shinyValue.BackColor = System.Drawing.Color.DarkGray;
            this.shinyValue.Location = new System.Drawing.Point(85, 128);
            this.shinyValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shinyValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shinyValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.shinyValue.Name = "shinyValue";
            this.shinyValue.Size = new System.Drawing.Size(80, 23);
            this.shinyValue.TabIndex = 50;
            this.shinyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shinyValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeValue
            // 
            this.typeValue.BackColor = System.Drawing.Color.DarkGray;
            this.typeValue.Location = new System.Drawing.Point(85, 21);
            this.typeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeValue.Maximum = new decimal(new int[] {
            5078,
            0,
            0,
            0});
            this.typeValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.typeValue.Name = "typeValue";
            this.typeValue.Size = new System.Drawing.Size(80, 23);
            this.typeValue.TabIndex = 0;
            this.typeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typeValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label11.Location = new System.Drawing.Point(1, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Use Time:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scaleValue
            // 
            this.scaleValue.BackColor = System.Drawing.Color.DarkGray;
            this.scaleValue.Location = new System.Drawing.Point(85, 48);
            this.scaleValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.scaleValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.scaleValue.Name = "scaleValue";
            this.scaleValue.Size = new System.Drawing.Size(80, 23);
            this.scaleValue.TabIndex = 12;
            this.scaleValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scaleValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label6.Location = new System.Drawing.Point(3, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Scale:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // useValue
            // 
            this.useValue.BackColor = System.Drawing.Color.DarkGray;
            this.useValue.Location = new System.Drawing.Point(85, 195);
            this.useValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.useValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.useValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.useValue.Name = "useValue";
            this.useValue.Size = new System.Drawing.Size(80, 23);
            this.useValue.TabIndex = 15;
            this.useValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.useValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label28.Location = new System.Drawing.Point(2, 304);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 23);
            this.label28.TabIndex = 47;
            this.label28.Text = "Range:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stackValue
            // 
            this.stackValue.BackColor = System.Drawing.Color.DarkGray;
            this.stackValue.Location = new System.Drawing.Point(85, 74);
            this.stackValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stackValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.stackValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.stackValue.Name = "stackValue";
            this.stackValue.Size = new System.Drawing.Size(80, 23);
            this.stackValue.TabIndex = 49;
            this.stackValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stackValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // rangeValue
            // 
            this.rangeValue.BackColor = System.Drawing.Color.DarkGray;
            this.rangeValue.Location = new System.Drawing.Point(85, 304);
            this.rangeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rangeValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rangeValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.rangeValue.Name = "rangeValue";
            this.rangeValue.Size = new System.Drawing.Size(80, 23);
            this.rangeValue.TabIndex = 46;
            this.rangeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rangeValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label12.Location = new System.Drawing.Point(2, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "Reuse Delay:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label29.Location = new System.Drawing.Point(2, 74);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 23);
            this.label29.TabIndex = 48;
            this.label29.Text = "Stack:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delayValue
            // 
            this.delayValue.BackColor = System.Drawing.Color.DarkGray;
            this.delayValue.Location = new System.Drawing.Point(85, 222);
            this.delayValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delayValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.delayValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.delayValue.Name = "delayValue";
            this.delayValue.Size = new System.Drawing.Size(80, 23);
            this.delayValue.TabIndex = 18;
            this.delayValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // knockValue
            // 
            this.knockValue.BackColor = System.Drawing.Color.DarkGray;
            this.knockValue.Location = new System.Drawing.Point(85, 249);
            this.knockValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.knockValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.knockValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.knockValue.Name = "knockValue";
            this.knockValue.Size = new System.Drawing.Size(80, 23);
            this.knockValue.TabIndex = 13;
            this.knockValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.knockValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label4.Location = new System.Drawing.Point(2, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Knockback:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label3.Location = new System.Drawing.Point(2, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Damage:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // damageValue
            // 
            this.damageValue.BackColor = System.Drawing.Color.DarkGray;
            this.damageValue.Location = new System.Drawing.Point(85, 276);
            this.damageValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.damageValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.damageValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.damageValue.Name = "damageValue";
            this.damageValue.Size = new System.Drawing.Size(80, 23);
            this.damageValue.TabIndex = 3;
            this.damageValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.damageValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // itemList
            // 
            this.itemList.AutoSize = true;
            this.itemList.Location = new System.Drawing.Point(125, 10);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(52, 15);
            this.itemList.TabIndex = 32;
            this.itemList.TabStop = true;
            this.itemList.Text = "Item List";
            this.itemList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // editItemLbl
            // 
            this.editItemLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.editItemLbl.Location = new System.Drawing.Point(6, 22);
            this.editItemLbl.Name = "editItemLbl";
            this.editItemLbl.Size = new System.Drawing.Size(169, 35);
            this.editItemLbl.TabIndex = 10;
            this.editItemLbl.Text = "NULL";
            this.editItemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editItemLbl.Click += new System.EventHandler(this.editItemLbl_Click);
            // 
            // applyItem
            // 
            this.applyItem.Location = new System.Drawing.Point(53, 490);
            this.applyItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyItem.Name = "applyItem";
            this.applyItem.Size = new System.Drawing.Size(122, 22);
            this.applyItem.TabIndex = 31;
            this.applyItem.Text = "APPLY";
            this.applyItem.UseVisualStyleBackColor = true;
            this.applyItem.Click += new System.EventHandler(this.applyItem_Click);
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.BackColor = System.Drawing.Color.DimGray;
            this.itemLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.itemLbl.ForeColor = System.Drawing.Color.Black;
            this.itemLbl.Location = new System.Drawing.Point(13, 28);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(86, 15);
            this.itemLbl.TabIndex = 5;
            this.itemLbl.Text = "[2] EDIT ITEM";
            this.itemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.itemLbl.Visible = false;
            // 
            // playerLbl
            // 
            this.playerLbl.AutoSize = true;
            this.playerLbl.BackColor = System.Drawing.Color.DimGray;
            this.playerLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.playerLbl.ForeColor = System.Drawing.Color.Black;
            this.playerLbl.Location = new System.Drawing.Point(13, 9);
            this.playerLbl.Name = "playerLbl";
            this.playerLbl.Size = new System.Drawing.Size(100, 15);
            this.playerLbl.TabIndex = 6;
            this.playerLbl.Text = "[1] EDIT PLAYER";
            this.playerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerLbl.Visible = false;
            // 
            // ldLbl
            // 
            this.ldLbl.AutoSize = true;
            this.ldLbl.BackColor = System.Drawing.Color.DimGray;
            this.ldLbl.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ldLbl.ForeColor = System.Drawing.Color.Black;
            this.ldLbl.Location = new System.Drawing.Point(132, 9);
            this.ldLbl.Name = "ldLbl";
            this.ldLbl.Size = new System.Drawing.Size(247, 34);
            this.ldLbl.TabIndex = 7;
            this.ldLbl.Text = "!~* LOADING *~!";
            this.ldLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadProgress
            // 
            this.loadProgress.BackColor = System.Drawing.Color.Gray;
            this.loadProgress.ForeColor = System.Drawing.Color.Black;
            this.loadProgress.Location = new System.Drawing.Point(132, 49);
            this.loadProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadProgress.Name = "loadProgress";
            this.loadProgress.Size = new System.Drawing.Size(246, 25);
            this.loadProgress.Step = 20;
            this.loadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadProgress.TabIndex = 8;
            // 
            // npcGroup
            // 
            this.npcGroup.BackColor = System.Drawing.Color.Gray;
            this.npcGroup.Controls.Add(this.applyNpc);
            this.npcGroup.Controls.Add(this.npcLink);
            this.npcGroup.Controls.Add(this.npcDetailGroup);
            this.npcGroup.Controls.Add(this.label18);
            this.npcGroup.Controls.Add(this.refreshList);
            this.npcGroup.Controls.Add(this.npcList);
            this.npcGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.npcGroup.Location = new System.Drawing.Point(200, 96);
            this.npcGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcGroup.Name = "npcGroup";
            this.npcGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcGroup.Size = new System.Drawing.Size(179, 648);
            this.npcGroup.TabIndex = 12;
            this.npcGroup.TabStop = false;
            this.npcGroup.Text = "Edit NPC";
            this.npcGroup.Visible = false;
            // 
            // applyNpc
            // 
            this.applyNpc.Location = new System.Drawing.Point(6, 620);
            this.applyNpc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyNpc.Name = "applyNpc";
            this.applyNpc.Size = new System.Drawing.Size(167, 22);
            this.applyNpc.TabIndex = 40;
            this.applyNpc.Text = "APPLY";
            this.applyNpc.UseVisualStyleBackColor = true;
            // 
            // npcLink
            // 
            this.npcLink.AutoSize = true;
            this.npcLink.Location = new System.Drawing.Point(120, 10);
            this.npcLink.Name = "npcLink";
            this.npcLink.Size = new System.Drawing.Size(50, 15);
            this.npcLink.TabIndex = 39;
            this.npcLink.TabStop = true;
            this.npcLink.Text = "Npc List";
            this.npcLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // npcDetailGroup
            // 
            this.npcDetailGroup.Controls.Add(this.isFriendly);
            this.npcDetailGroup.Controls.Add(this.noGravity);
            this.npcDetailGroup.Controls.Add(this.closeDoors);
            this.npcDetailGroup.Controls.Add(this.isInvincible);
            this.npcDetailGroup.Controls.Add(this.noColliision);
            this.npcDetailGroup.Controls.Add(this.npcDamage);
            this.npcDetailGroup.Controls.Add(this.npcStyle);
            this.npcDetailGroup.Controls.Add(this.npcLife);
            this.npcDetailGroup.Controls.Add(this.npcMax);
            this.npcDetailGroup.Controls.Add(this.npcSpeed);
            this.npcDetailGroup.Controls.Add(this.npcType);
            this.npcDetailGroup.Controls.Add(this.npcBoss);
            this.npcDetailGroup.Controls.Add(this.npcTown);
            this.npcDetailGroup.Controls.Add(this.npcScale);
            this.npcDetailGroup.Controls.Add(this.label15);
            this.npcDetailGroup.Controls.Add(this.label22);
            this.npcDetailGroup.Controls.Add(this.label13);
            this.npcDetailGroup.Controls.Add(this.label19);
            this.npcDetailGroup.Controls.Add(this.label20);
            this.npcDetailGroup.Controls.Add(this.label21);
            this.npcDetailGroup.Controls.Add(this.label16);
            this.npcDetailGroup.Controls.Add(this.label14);
            this.npcDetailGroup.Controls.Add(this.label17);
            this.npcDetailGroup.Location = new System.Drawing.Point(6, 182);
            this.npcDetailGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcDetailGroup.Name = "npcDetailGroup";
            this.npcDetailGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcDetailGroup.Size = new System.Drawing.Size(167, 433);
            this.npcDetailGroup.TabIndex = 38;
            this.npcDetailGroup.TabStop = false;
            this.npcDetailGroup.Text = "NULL";
            // 
            // isFriendly
            // 
            this.isFriendly.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.isFriendly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.isFriendly.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.isFriendly.Location = new System.Drawing.Point(76, 285);
            this.isFriendly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isFriendly.Name = "isFriendly";
            this.isFriendly.Size = new System.Drawing.Size(85, 41);
            this.isFriendly.TabIndex = 45;
            this.isFriendly.Text = "Friendly";
            this.isFriendly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isFriendly.UseVisualStyleBackColor = true;
            // 
            // noGravity
            // 
            this.noGravity.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noGravity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.noGravity.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noGravity.Location = new System.Drawing.Point(76, 377);
            this.noGravity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noGravity.Name = "noGravity";
            this.noGravity.Size = new System.Drawing.Size(85, 41);
            this.noGravity.TabIndex = 44;
            this.noGravity.Text = "No Gravity";
            this.noGravity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noGravity.UseVisualStyleBackColor = true;
            // 
            // closeDoors
            // 
            this.closeDoors.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeDoors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.closeDoors.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeDoors.Location = new System.Drawing.Point(1, 377);
            this.closeDoors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeDoors.Name = "closeDoors";
            this.closeDoors.Size = new System.Drawing.Size(85, 41);
            this.closeDoors.TabIndex = 43;
            this.closeDoors.Text = "Close Doors";
            this.closeDoors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeDoors.UseVisualStyleBackColor = true;
            // 
            // isInvincible
            // 
            this.isInvincible.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.isInvincible.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.isInvincible.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.isInvincible.Location = new System.Drawing.Point(1, 330);
            this.isInvincible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isInvincible.Name = "isInvincible";
            this.isInvincible.Size = new System.Drawing.Size(85, 41);
            this.isInvincible.TabIndex = 42;
            this.isInvincible.Text = "Invincible";
            this.isInvincible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isInvincible.UseVisualStyleBackColor = true;
            // 
            // noColliision
            // 
            this.noColliision.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noColliision.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.noColliision.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noColliision.Location = new System.Drawing.Point(76, 330);
            this.noColliision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noColliision.Name = "noColliision";
            this.noColliision.Size = new System.Drawing.Size(85, 41);
            this.noColliision.TabIndex = 41;
            this.noColliision.Text = "No Collison";
            this.noColliision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noColliision.UseVisualStyleBackColor = true;
            // 
            // npcDamage
            // 
            this.npcDamage.BackColor = System.Drawing.Color.DarkGray;
            this.npcDamage.Location = new System.Drawing.Point(80, 202);
            this.npcDamage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcDamage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npcDamage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcDamage.Name = "npcDamage";
            this.npcDamage.Size = new System.Drawing.Size(80, 23);
            this.npcDamage.TabIndex = 18;
            this.npcDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npcDamage.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // npcStyle
            // 
            this.npcStyle.BackColor = System.Drawing.Color.DarkGray;
            this.npcStyle.Location = new System.Drawing.Point(80, 112);
            this.npcStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcStyle.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npcStyle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcStyle.Name = "npcStyle";
            this.npcStyle.Size = new System.Drawing.Size(80, 23);
            this.npcStyle.TabIndex = 10;
            this.npcStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npcStyle.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // npcLife
            // 
            this.npcLife.BackColor = System.Drawing.Color.DarkGray;
            this.npcLife.Location = new System.Drawing.Point(80, 229);
            this.npcLife.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcLife.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npcLife.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcLife.Name = "npcLife";
            this.npcLife.Size = new System.Drawing.Size(80, 23);
            this.npcLife.TabIndex = 13;
            this.npcLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npcLife.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // npcMax
            // 
            this.npcMax.BackColor = System.Drawing.Color.DarkGray;
            this.npcMax.Location = new System.Drawing.Point(80, 256);
            this.npcMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npcMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcMax.Name = "npcMax";
            this.npcMax.Size = new System.Drawing.Size(80, 23);
            this.npcMax.TabIndex = 14;
            this.npcMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npcMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // npcSpeed
            // 
            this.npcSpeed.BackColor = System.Drawing.Color.DarkGray;
            this.npcSpeed.Location = new System.Drawing.Point(80, 175);
            this.npcSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npcSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcSpeed.Name = "npcSpeed";
            this.npcSpeed.Size = new System.Drawing.Size(80, 23);
            this.npcSpeed.TabIndex = 16;
            this.npcSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npcSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcSpeed.ValueChanged += new System.EventHandler(this.npcSpeed_ValueChanged);
            // 
            // npcType
            // 
            this.npcType.BackColor = System.Drawing.Color.DarkGray;
            this.npcType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.npcType.Location = new System.Drawing.Point(80, 31);
            this.npcType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcType.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npcType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcType.Name = "npcType";
            this.npcType.Size = new System.Drawing.Size(80, 23);
            this.npcType.TabIndex = 0;
            this.npcType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npcType.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // npcBoss
            // 
            this.npcBoss.BackColor = System.Drawing.Color.DarkGray;
            this.npcBoss.Location = new System.Drawing.Point(80, 58);
            this.npcBoss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcBoss.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npcBoss.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcBoss.Name = "npcBoss";
            this.npcBoss.Size = new System.Drawing.Size(80, 23);
            this.npcBoss.TabIndex = 3;
            this.npcBoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npcBoss.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // npcTown
            // 
            this.npcTown.BackColor = System.Drawing.Color.DarkGray;
            this.npcTown.Location = new System.Drawing.Point(80, 85);
            this.npcTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcTown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npcTown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcTown.Name = "npcTown";
            this.npcTown.Size = new System.Drawing.Size(80, 23);
            this.npcTown.TabIndex = 4;
            this.npcTown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npcTown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // npcScale
            // 
            this.npcScale.BackColor = System.Drawing.Color.DarkGray;
            this.npcScale.Location = new System.Drawing.Point(80, 148);
            this.npcScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npcScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.npcScale.Name = "npcScale";
            this.npcScale.Size = new System.Drawing.Size(80, 23);
            this.npcScale.TabIndex = 6;
            this.npcScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npcScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label15.Location = new System.Drawing.Point(1, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 24);
            this.label15.TabIndex = 5;
            this.label15.Text = "Boss:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label22.Location = new System.Drawing.Point(3, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 23);
            this.label22.TabIndex = 19;
            this.label22.Text = "Speed:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label13.Location = new System.Drawing.Point(3, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "Life:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label19.Location = new System.Drawing.Point(3, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 23);
            this.label19.TabIndex = 12;
            this.label19.Text = "AI Style:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label20.Location = new System.Drawing.Point(3, 148);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 23);
            this.label20.TabIndex = 17;
            this.label20.Text = "Scale:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label21.Location = new System.Drawing.Point(3, 256);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 23);
            this.label21.TabIndex = 15;
            this.label21.Text = "Max Life:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label16.Location = new System.Drawing.Point(3, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 23);
            this.label16.TabIndex = 2;
            this.label16.Text = "Damage:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label14.Location = new System.Drawing.Point(3, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 23);
            this.label14.TabIndex = 9;
            this.label14.Text = "Town:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label17.Location = new System.Drawing.Point(3, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 23);
            this.label17.TabIndex = 1;
            this.label17.Text = "Type:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label18.Location = new System.Drawing.Point(7, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 18);
            this.label18.TabIndex = 37;
            this.label18.Text = "Distance | Name (Health)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refreshList
            // 
            this.refreshList.Location = new System.Drawing.Point(7, 156);
            this.refreshList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshList.Name = "refreshList";
            this.refreshList.Size = new System.Drawing.Size(167, 22);
            this.refreshList.TabIndex = 12;
            this.refreshList.Text = "RESCAN";
            this.refreshList.UseVisualStyleBackColor = true;
            this.refreshList.Click += new System.EventHandler(this.refreshList_Click);
            // 
            // npcList
            // 
            this.npcList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.npcList.BackColor = System.Drawing.Color.DarkGray;
            this.npcList.FormattingEnabled = true;
            this.npcList.ItemHeight = 15;
            this.npcList.Location = new System.Drawing.Point(7, 58);
            this.npcList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(166, 94);
            this.npcList.TabIndex = 11;
            this.npcList.SelectedIndexChanged += new System.EventHandler(this.npcList_SelectedIndexChanged);
            // 
            // playerGroup
            // 
            this.playerGroup.BackColor = System.Drawing.Color.Transparent;
            this.playerGroup.Controls.Add(this.groupBox1);
            this.playerGroup.Controls.Add(this.groupBox2);
            this.playerGroup.ForeColor = System.Drawing.Color.Transparent;
            this.playerGroup.Location = new System.Drawing.Point(3, 618);
            this.playerGroup.Name = "playerGroup";
            this.playerGroup.Size = new System.Drawing.Size(390, 286);
            this.playerGroup.TabIndex = 13;
            this.playerGroup.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Player";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.difficultyValue);
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.dragValue);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.accelerationValue);
            this.groupBox3.Controls.Add(this.maxSpeedValue);
            this.groupBox3.Controls.Add(this.gravityValue);
            this.groupBox3.Controls.Add(this.maxBreathValue);
            this.groupBox3.Controls.Add(this.maxManaValue);
            this.groupBox3.Controls.Add(this.maxLifeValue);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 247);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // difficultyValue
            // 
            this.difficultyValue.BackColor = System.Drawing.Color.DarkGray;
            this.difficultyValue.Location = new System.Drawing.Point(85, 24);
            this.difficultyValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.difficultyValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.difficultyValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.difficultyValue.Name = "difficultyValue";
            this.difficultyValue.Size = new System.Drawing.Size(80, 23);
            this.difficultyValue.TabIndex = 78;
            this.difficultyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.difficultyValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label42.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label42.Location = new System.Drawing.Point(4, 22);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(70, 19);
            this.label42.TabIndex = 77;
            this.label42.Text = "Difficulty:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dragValue
            // 
            this.dragValue.BackColor = System.Drawing.Color.DarkGray;
            this.dragValue.Location = new System.Drawing.Point(85, 132);
            this.dragValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dragValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.dragValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dragValue.Name = "dragValue";
            this.dragValue.Size = new System.Drawing.Size(80, 23);
            this.dragValue.TabIndex = 75;
            this.dragValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dragValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label41.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label41.Location = new System.Drawing.Point(4, 130);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(70, 19);
            this.label41.TabIndex = 76;
            this.label41.Text = "Drag:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accelerationValue
            // 
            this.accelerationValue.BackColor = System.Drawing.Color.DarkGray;
            this.accelerationValue.Location = new System.Drawing.Point(85, 213);
            this.accelerationValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accelerationValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.accelerationValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.accelerationValue.Name = "accelerationValue";
            this.accelerationValue.Size = new System.Drawing.Size(80, 23);
            this.accelerationValue.TabIndex = 74;
            this.accelerationValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accelerationValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // maxSpeedValue
            // 
            this.maxSpeedValue.BackColor = System.Drawing.Color.DarkGray;
            this.maxSpeedValue.Location = new System.Drawing.Point(85, 186);
            this.maxSpeedValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxSpeedValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxSpeedValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.maxSpeedValue.Name = "maxSpeedValue";
            this.maxSpeedValue.Size = new System.Drawing.Size(80, 23);
            this.maxSpeedValue.TabIndex = 70;
            this.maxSpeedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxSpeedValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // gravityValue
            // 
            this.gravityValue.BackColor = System.Drawing.Color.DarkGray;
            this.gravityValue.Location = new System.Drawing.Point(85, 159);
            this.gravityValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gravityValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.gravityValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.gravityValue.Name = "gravityValue";
            this.gravityValue.Size = new System.Drawing.Size(80, 23);
            this.gravityValue.TabIndex = 68;
            this.gravityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gravityValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // maxBreathValue
            // 
            this.maxBreathValue.BackColor = System.Drawing.Color.DarkGray;
            this.maxBreathValue.Location = new System.Drawing.Point(85, 105);
            this.maxBreathValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxBreathValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxBreathValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.maxBreathValue.Name = "maxBreathValue";
            this.maxBreathValue.Size = new System.Drawing.Size(80, 23);
            this.maxBreathValue.TabIndex = 66;
            this.maxBreathValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxBreathValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // maxManaValue
            // 
            this.maxManaValue.BackColor = System.Drawing.Color.DarkGray;
            this.maxManaValue.Location = new System.Drawing.Point(85, 78);
            this.maxManaValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxManaValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxManaValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.maxManaValue.Name = "maxManaValue";
            this.maxManaValue.Size = new System.Drawing.Size(80, 23);
            this.maxManaValue.TabIndex = 64;
            this.maxManaValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxManaValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // maxLifeValue
            // 
            this.maxLifeValue.BackColor = System.Drawing.Color.DarkGray;
            this.maxLifeValue.Location = new System.Drawing.Point(85, 51);
            this.maxLifeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxLifeValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxLifeValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.maxLifeValue.Name = "maxLifeValue";
            this.maxLifeValue.Size = new System.Drawing.Size(80, 23);
            this.maxLifeValue.TabIndex = 62;
            this.maxLifeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxLifeValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label38.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label38.Location = new System.Drawing.Point(4, 186);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(74, 19);
            this.label38.TabIndex = 73;
            this.label38.Text = "Max Speed:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label39.Location = new System.Drawing.Point(1, 212);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(82, 19);
            this.label39.TabIndex = 71;
            this.label39.Text = "Acceleration:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label40.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label40.Location = new System.Drawing.Point(4, 157);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(70, 19);
            this.label40.TabIndex = 69;
            this.label40.Text = "Gravity:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label37.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label37.Location = new System.Drawing.Point(3, 105);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(75, 19);
            this.label37.TabIndex = 67;
            this.label37.Text = "Max Breath:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label36.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label36.Location = new System.Drawing.Point(4, 76);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(70, 19);
            this.label36.TabIndex = 65;
            this.label36.Text = "Max Mana:";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label35.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label35.Location = new System.Drawing.Point(4, 49);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(70, 19);
            this.label35.TabIndex = 63;
            this.label35.Text = "Max Life:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.applyPlayer);
            this.groupBox2.Controls.Add(this.jumpsValue);
            this.groupBox2.Controls.Add(this.killsValue);
            this.groupBox2.Controls.Add(this.itemsValue);
            this.groupBox2.Controls.Add(this.godValue);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(160, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 144);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // applyPlayer
            // 
            this.applyPlayer.Location = new System.Drawing.Point(45, 116);
            this.applyPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyPlayer.Name = "applyPlayer";
            this.applyPlayer.Size = new System.Drawing.Size(167, 22);
            this.applyPlayer.TabIndex = 41;
            this.applyPlayer.Text = "APPLY";
            this.applyPlayer.UseVisualStyleBackColor = true;
            // 
            // jumpsValue
            // 
            this.jumpsValue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.jumpsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.jumpsValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.jumpsValue.Location = new System.Drawing.Point(124, 56);
            this.jumpsValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jumpsValue.Name = "jumpsValue";
            this.jumpsValue.Size = new System.Drawing.Size(79, 52);
            this.jumpsValue.TabIndex = 60;
            this.jumpsValue.Text = "Infinite Jumps";
            this.jumpsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jumpsValue.UseVisualStyleBackColor = true;
            // 
            // killsValue
            // 
            this.killsValue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.killsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.killsValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.killsValue.Location = new System.Drawing.Point(124, 11);
            this.killsValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.killsValue.Name = "killsValue";
            this.killsValue.Size = new System.Drawing.Size(79, 41);
            this.killsValue.TabIndex = 59;
            this.killsValue.Text = "Instant Kills";
            this.killsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.killsValue.UseVisualStyleBackColor = true;
            // 
            // itemsValue
            // 
            this.itemsValue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.itemsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.itemsValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.itemsValue.Location = new System.Drawing.Point(41, 56);
            this.itemsValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemsValue.Name = "itemsValue";
            this.itemsValue.Size = new System.Drawing.Size(79, 52);
            this.itemsValue.TabIndex = 58;
            this.itemsValue.Text = "Unlimited Items";
            this.itemsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.itemsValue.UseVisualStyleBackColor = true;
            // 
            // godValue
            // 
            this.godValue.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.godValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.godValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.godValue.Location = new System.Drawing.Point(41, 11);
            this.godValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.godValue.Name = "godValue";
            this.godValue.Size = new System.Drawing.Size(79, 41);
            this.godValue.TabIndex = 57;
            this.godValue.Text = "God Mode";
            this.godValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.godValue.UseVisualStyleBackColor = true;
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(395, 908);
            this.Controls.Add(this.npcGroup);
            this.Controls.Add(this.loadProgress);
            this.Controls.Add(this.ldLbl);
            this.Controls.Add(this.playerLbl);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.itemGroup);
            this.Controls.Add(this.npcLbl);
            this.Controls.Add(this.playerGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Tag = "gmHack";
            this.Text = "MemoryManipulator (1.0)";
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.itemGroup.ResumeLayout(false);
            this.itemGroup.PerformLayout();
            this.itemPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectileValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wandValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoSpeedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoValue)).EndInit();
            this.itemPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hammerValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxStackValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shinyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knockValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageValue)).EndInit();
            this.npcGroup.ResumeLayout(false);
            this.npcGroup.PerformLayout();
            this.npcDetailGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.npcDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcScale)).EndInit();
            this.playerGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.difficultyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerationValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBreathValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxManaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLifeValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label npcLbl;
        private GroupBox itemGroup;
        private Label label1;
        private Label label3;
        private Label editItemLbl;
        private Label itemLbl;
        private Label playerLbl;
        private Label ldLbl;
        public ProgressBar loadProgress;
        private GroupBox itemPage2;
        private Label label12;
        private Label label4;
        private Label label11;
        private Label label5;
        private Label label2;
        private LinkLabel itemList;
        private Button applyItem;
        private GroupBox npcGroup;
        private ListBox npcList;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button refreshList;
        private LinkLabel npcLink;
        private GroupBox npcDetailGroup;
        private Label label13;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Button applyNpc;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label28;
        private Label label29;
        private Button nxtPage;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel playerGroup;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label33;
        private Label label7;
        private GroupBox groupBox3;
        private Label label42;
        private Label label41;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label43;
        private Label label32;
        private Label label30;
        private Label label31;
        private Button applyPlayer;
        internal NumericUpDown typeValue;
        internal NumericUpDown damageValue;
        internal NumericUpDown delayValue;
        internal NumericUpDown useValue;
        internal Label label6;
        internal NumericUpDown knockValue;
        internal NumericUpDown scaleValue;
        internal NumericUpDown ammoSpeedValue;
        internal NumericUpDown ammoValue;
        internal NumericUpDown legValue;
        internal NumericUpDown bodyValue;
        internal NumericUpDown headValue;
        internal NumericUpDown rangeValue;
        internal NumericUpDown stackValue;
        internal NumericUpDown wandValue;
        internal NumericUpDown tileValue;
        internal NumericUpDown wallValue;
        internal GroupBox itemPage1;
        internal NumericUpDown maxStackValue;
        internal NumericUpDown shinyValue;
        internal NumericUpDown hammerValue;
        internal NumericUpDown pickValue;
        internal NumericUpDown axeValue;
        internal NumericUpDown projectileValue;
        internal CheckBox rangedValue;
        internal CheckBox magicValue;
        internal CheckBox noMeleeValue;
        internal CheckBox meleeValue;
        internal CheckBox reuseValue;
        internal CheckBox accesoryValue;
        private Label curPage;
        internal NumericUpDown difficultyValue;
        internal NumericUpDown dragValue;
        internal NumericUpDown accelerationValue;
        internal NumericUpDown maxSpeedValue;
        internal NumericUpDown gravityValue;
        internal NumericUpDown maxBreathValue;
        internal NumericUpDown maxManaValue;
        internal NumericUpDown maxLifeValue;
        internal CheckBox jumpsValue;
        internal CheckBox killsValue;
        internal CheckBox itemsValue;
        internal CheckBox godValue;
        internal NumericUpDown npcScale;
        internal NumericUpDown npcTown;
        internal NumericUpDown npcBoss;
        internal NumericUpDown npcType;
        internal NumericUpDown npcStyle;
        internal NumericUpDown npcLife;
        internal NumericUpDown npcMax;
        internal NumericUpDown npcSpeed;
        internal NumericUpDown npcDamage;
        internal CheckBox isFriendly;
        internal CheckBox noGravity;
        internal CheckBox closeDoors;
        internal CheckBox isInvincible;
        internal CheckBox noColliision;
    }
}

