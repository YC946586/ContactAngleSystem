   M S B A M L   `   `   `  ����K  GContactAngleMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ContactAngleMain.LanguageContactAngleMain.Language  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   CompanyName  SysName  File 
 Config  Analysis  Help  English  SimplifiedChinese  TraditionalChinese 	 HardwareStatus 
 RunningStatus  VideoCurrentFrame  AllFrame  HardwareStatus1  
DropVolume 	 Drops  Current 	 Query  Add  Edit 
 Delete 
 Export  OK 
 Cancel  New  Open  Save 
 Select 	 Judge 	 Start  ToDetect  Default   Start measuring ! To calculate " resetDel 	# Empty $ AngleQuerySystem % TensionQuerySystem & SurfaceEnergQuerySystem ' DeleteCurrentRecord ( 	Deleteall ) All 
* number + Thetestdate , The test of time - The operator . Sample number / The name of the solid 0 The left contact Angle 1 Right contact Angle 2 Differential contact Angle 3 Evaluation contact Angle 4 A few lines of inclination 5 Forward Angle 6 Receding Angle 7 Contact Angle 8 FileName 9 
DeleteFile : Test information ; 	Test data < The test data = The name of the liquid  > Name of the foreign minister ? Test method for @ The test environment A 	Test date B Operator C 	Test unit D Manufacturers 
E Remark F Criteria G Baseline on-line H Baseline off line I Minimum contact Angle J Maximum contact Angle K The standard deviatio L Forward contact Angle M Backward contact Angle N 	Lag Angle O Rolling Angle P Droplet size Q Droplet diameter R Contact Angle1 S Contact Angle2 T Contact Angle3 U Surface energy V Estimation method W Solid polar componen !X Dispersion component of solid  Y Solid hydrogen bonding force !Z solid van der Waals component [ solid Lewis acid component %\ !lewis base component of the solid ] Solid surface energy ^ SurfaceTension _ liquid density ` Foreign minister density a Refer to the size 	b G cm3 c mm d Density difference e Size amplification f Maximum width of droplet g Droplet calibration width h Amplification factor i Camera Settings j Camera type k ordinary l 
High speed m BrightnessContrastThreshold n 
brightness o contrast p 	Threshold q Slow to save Settings r total number of frames s Storage interval 	t frame u resolution of the 	v width 
w height 	x pixel y Quick save Settings z Frame triggered photograph { Frame stop taking pictures | Adaptive window 	} delay ~ Began to take pictures  Video frame Settings 
� frameS � from � Test set � Control mode � 
Drip speed � Drip quantity � 
Time delay 	� video � 
video Test � The first step � The second step � The third step � Pay attention to the prompt � Console Settings � Find equipment � Open the equipment � current site � Binding shaft � Binding lead � Binding � Can make � offline 	� reset � The callback feedback � Load factory Settings � Change the password � Drip control � The turntable � Total length of container � Total container capacity � Absolute position � speedKzt � site 	� model � firmware 	� shaft � lead � WettabilityAnalysis � Input information 
� Result � CheckAll � The adhesion work � Spreading coefficient � Adhesion tension � Calculated surface energy � Method to choose � Two liquid method � A method of liquid � liquid method � Three fluid method � mea liquid method � EOS A method of liquid � Extended Three fluid method � A liquid � Liquid2 � Liquid three � Calculate solid surface � Liquid database changes � Export data � Serial number � The dispersion component � The polar components � Van der Waals component � Lewis acid component � Lewis base component � Hydrogen bonding force � Query by date � Query by measured value � Query by operator � Query by sample � Delete current record � Delete all records � Year 	� month � day 	� hours � minutes � Feature selection .� *Automatic fitting method for contact Angle � Circle fittinge � Elliptic fitting � LY - AP fitting � LY - SD fitting E� AThe experimental diagram of contact Angle is automatically fitted #� Manual fitting of contact Angle � Three point fitting circle � Five points fit the ellipse � Baseline fitting (� $Automatic baseline fitting (default) -� )Manually fit the horizontal/tilt baseline )� %Manually fitting the surface baseline � Surface tension � Automatic fitting test 8� 4The surface tension diagram was fitted automatically � Wettability analysis � The toolbar � Drop control Z � The turntable R 2� .Note: check is displayed. Check is the default � User management � The serial number � 
Login name � role � Creation time � 	operation L� HThe surface tension calculation must be imported into the test template! � Copyright statement ,� (Guangdong Beidou Precision Instrument Co � 
Contact us 1� -Guangdong Beidou Precision Instrument Co. LTD � 	Telephone � fax � The url 1� -Table interface measurement system Version1.0 � The sample name � Measured mean�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      1local'clr-namespace:ContactAngleMain.Language  5      .sys&clr-namespace:System;assembly=mscorlib  5      %m.  &	        &	 @     &	 w     &	 �     &	 �     &	 �     &	     &	 -    &	 U    &		 }    &	
 �    &	 �    &	     &	 &    &	 H    &	 m    &	 �    &	 �    &	 �    &	 �    &	     &	 )    &	 G    &	 e    &	 �    &	 �    &	 �    &	 �    &	 �    &	     &	 7    &	 [    &	      &	! �    &	" �    &	# �    &	$ �    &	% '    &	& Q    &	' ~    &	( �    &	) �    &	* �    &	+     &	, 2    &	- V    &	. w    &	/ �    &	0 �    &	1 �    &	2     &	3 .    &	4 U    &	5 |    &	6 �    &	7 �    &	8 �    &	9     &	: 3    &	; W    &	< {    &	= �    &	> �    &	? �    &	@ 	    &	A /	    &	B S	    &	C t	    &	D �	    &	E �	    &	F �	    &	G �	    &	H %
    &	I L
    &	J s
    &	K �
    &	L �
    &	M �
    &	N 	    &	O *    &	P K    &	Q o    &	R �    &	S �    &	T �    &	U �    &	V     &	W >    &	X h    &	Y �    &	Z �    &	[ �    &	\     &	] F    &	^ m    &	_ �    &	` �    &	a �    &	b �    &	c %    &	d C    &	e d    &	f �    &	g �    &	h �    &	i      &	j $    &	k K    &	l i    &	m �    &	n �    &	o �    &	p �    &	q     &	r 7    &	s X    &	t |    &	u �    &	v �    &	w �    &	x �    &	y     &	z >    &	{ e    &	| �    &	} �    &	~ �    &	 �    &	� '    &	� D    &	� _    &	� �    &	� �    &	� �    &	� �    &	�     &	� =    &	� b    &	� �    &	� �    &	� �    &	� 7    &	� ^    &	� �    &	� �    &	� �    &	� �    &	�     &	� 4    &	� R    &	� p    &	� �    &	� �    &	� �    &	�      &	� (    &	� J    &	� q    &	� �    &	� �    &	� �    &	� �    &	�     &	� 4    &	� O    &	� m    &	� �    &	� �    &	� �    &	� �    &	� !    &	� K    &	� u    &	� �    &	� �    &	� �    &	�     &	� 4    &	� e    &	� �    &	� �    &	� �    &	�     &	� ,    &	� M    &	� �    &	� �    &	� �    &	� �    &	�     &	� >    &	� e    &	� �    &	� �    &	� �    &	�     &	� .    &	� X    &	�     &	� �    &	� �    &	� �    &	� 	    &	� $    &	� B    &	� `    &	� �    &	� �    &	� �    &	� �    &	� %    &	� K    &	� �    &	� �    &	� �    &	�     &	� &    &	� \    &	� �    &	� �    &	� �    &	�      &	� J     &	� q     &	� �     &	� �     &	� �     &	� !    &	� @!    &	� ^!    &	� !    &	� �!    &	� �!    &	� �!    &	� $"    &	� H"    &	� �#    &	� �#    &	� $    &	� !$    &	� ?$    &	� ]$    &	� �$    &	� �$    ��5      ($廣東北斗精密儀器有限公司��5      ��5	      表界面分析測量系統��5      ��5      	文件(F)��5      ��5      	配置(C)��5      ��5      	分析(O)��5      ��5      	幫助(H)��5      ��5      
英文��5      ��5!      簡體中文��5#      ��5%      繁體中文��5'      ��5)      硬件狀態：��5+      ��5-      運行狀態：��5/      ��51      視頻當前幀：��53      ��55      	總幀：��57      ��59      
正常��5;      ��5=      	滴液量��5?      ��5@      
滴液��5B      ��5C      
當前��5E      ��5H      
查詢��6#   ��5I      
增加��6!   ��5J      
編輯��6"   ��5K      
刪除��6$   ��5L      
導出��6$   ��5M      
確定��6    ��5N      
取消��6$   ��5O      
新建��6!   ��5P      
打開��6"   ��5Q      
保存��6"   ��5R      
選額��6$   ��5S      
判斷��6#   ��5T      
開始��6#   ��5U      重新檢測��6(   ��5V      恢復默認��6'   ��5W      開始測量��6/   ��5X      
計算��6*   ��5Y      
重置��6&   ��5Z      
清空��6#   ��5\      角度查詢系統��62   ��5]      張力查詢系統��64   ��5^      表面能查詢系統��6:   ��5_      刪除當前記錄��65   ��5`      刪除全部記錄��6+   ��5a      
全部��6!   ��5b      
序號��6$   ��5c      測試日期��6+   ��5d      測試時間��60   ��5e      	操作者��6+   ��5f      樣品編號��6-   ��5g      固體名稱��65   ��5h      左接觸角��66   ��5i      右接觸角��63   ��5j      差額接觸角��6;   ��5k      評價接觸角��69   ��5l      幾綫傾斜角��6;   ��5m      前進傾斜角��6.   ��5n      後退傾斜角��6/   ��5q      	接觸角��6,   ��5r      文件名稱��6(   ��5s      刪除文件��6*   ��5t      實驗信息��60   ��5v      實驗數據��6)   ��5w      實驗數據��6-   ��5x      液體名稱��66   ��5y      外相名稱��6<   ��5z      實驗方法��6/   ��5{      實驗環境��64   ��5|      實驗日期��6)   ��5}      	操作者��6'   ��5~      實驗單位��6)   ��5      仪器厂家��6-   ��5�      
備注��6$   ��5�      判斷標準��6(   ��5�      基准值上綫��61   ��5�      基准值下綫��62   ��5�      最小接觸角��66   ��5�      最大接觸角��66   ��5�      	標準差��64   ��5�      前进接觸角��66   ��5�      后退接觸角��67   ��5�      	滞后角��6(   ��5�      	滾動角��6,   ��5�      液滴體積��6,   ��5�      液滴直径��60   ��5�      
接触角1��6.   ��5�      
接触角2��6.   ��5�      
接触角3��6.   ��5�      	表面能��6-   ��5�      估算方法��61   ��5�      固體极性分量��66   ��5�      固體色散分量��6?   ��5�      固體氢键力��6=   ��5�      固體范德华分量��6@   ��5�      固體路易斯酸分量��6>   ��5�      固體路易斯碱分量��6E   ��5�      固體表面能��65   ��5�      表面張力��6.   ��5�      液體密度��6.   ��5�      外相密度��68   ��5�      參考尺寸��61   ��5�      克/立方厘米��6'   ��5�      
毫米��6    ��5�      	密度差��61   ��5�      尺寸放大��62   ��5�      液滴最大宽度��6:   ��5�      液滴标定宽度��6;   ��5�      放大因子��64   ��5�      相機設置��6/   ��5�      攝像機類型��6,   ��5�      
普通��6&   ��5�      
高速��6(   ��5�      亮度/对比度/阈值��6@   ��5�      
亮度��6(   ��5�      	对比度��6'   ��5�      
閾值��6'   ��5�      慢存设置��65   ��5�      	总帧数��65   ��5�      存儲間隔��60   ��5�      帧��6"   ��5�      	分辨率��60   ��5�      
宽度(W):��6'   ��5�      
高度(H):��6(   ��5�      
像素��6#   ��5�      快存设置��63   ��5�      帧触发拍照��6;   ��5�      帧停止拍照��6;   ��5�      自适应窗口��60   ��5�      
延遲��6#   ��5�      s开始拍照/录制��6:   ��5�      视频帧数设置��66   ��5�      	帧/s��6%   ��5�      從��6!   ��5�      實驗設置��6(   ��5�      控制模式��6,   ��5�      滴液速度ul/min��60   ��5�      滴液量（ul）��60   ��5�      延時（s）��6+   ��5�      
錄像��6#   ��5�      錄像+测试��6+   ��5�      	第一步��6-   ��5�      	第二步��6.   ��5�      	第三步��6-   ��5�      ^Z注：設置好所有參數后，點擊開始測試按钮自動囘到主界面開始測試��6U   ��5�      控制臺設置��61   ��5�      查找設備��6.   ��5�      打開設備��62   ��5�      當前站點ID��6.   ��5�      	綁定軸��6,   ��5�      绑定导程(mm):��61   ��5�      
綁定��6%   ��5�      
使能��6&   ��5�      
脫機��6%   ��5�      
清零��6#   ��5�      回调反馈��65   ��5�      載入出廠設置��67   ��5�      修改密碼��63   ��5�      滴液控制Z’��6.   ��5�      
旋转台R��6-   ��5�      容器縂長度��6:   ��5�      容器縂容量��69   ��5�      絕對位置��61   ��5�      
速度��6&   ��5�      
站点��6"   ��5�      
型号��6#   ��5�      
固件��6&   ��5�      轴��6"   ��5�      
导程��6"   ��5�      润湿性分析��64   ��5�      錄入信息��61   ��5�      分析結果��6&   ��5�      
全選��6&   ��5�      粘附功(mN/m)��66   ��5�      铺展系数(mN/m)��6;   ��5�      粘附张力(mN/m)��66   ��5�      計算表面能��6:   ��5�      方法選擇��60   ��5�      Zisman 二液法��67   ��5�      Fowkes一液法��67   ��5�      OWRK二液法��60   ��5�      Acid-Base Theory三液法��6A   ��5      Wu harmonic mean二液法��6@   ��5     EOS一液法��68   ��5     Extended Fowkes三液法��6I   ��5     	液體一��6'   ��5     	液體二��6&   ��5     	液體三��6+   ��5     计算固体表面自由能��6<   ��5      液体信息库更改/添加��6=   ��5     数据导出��6+   ��5	     
編號��6+   ��5     色散分量��68   ��5     极性分量��64   ��5     范德华分量��68   ��5     路易斯酸分量��66   ��5     路易斯碱分量��66   ��5     	氢键力��65   ��5     按日期者查詢��6/   ��5     按测量值查詢��69   ��5     按操作者查詢��63   ��5     按样品查詢��60   ��5     刪除當前記錄��67   ��5     删除全部記錄��64   ��5     年��6!   ��5     月��6"   ��5     日��6    ��5     
小時��6#   ��5     
分鐘��6%   ��5     功能選擇��61   ��5      接觸角自動擬合法��6N   ��5!     圓擬合法��6/   ��5"     橢圓擬合法��61   ��5#     LY-AP擬合法��63   ��5$     LY-SD擬合法��63   ��5%     "自動擬合接觸角實驗圖��6g   ��5&     接觸角手動擬合法��6C   ��5'     三點擬合圓��6;   ��5(     五點擬合橢圓��6=   ��5)     基綫擬合��60   ��5*     "自動擬合基綫（默認）��6J   ��5+     #手動擬合水平/傾斜基綫��6P   ��5,     手動擬合曲面基綫��6I   ��5-     表面張力��6/   ��5.     自動擬合測試��68   ��5/     %!自動擬合表面張力測試圖��6[   ��50     潤濕性分析��65   ��51     	工具欄��6*   ��52     滴液控制Z'��60   ��53     
旋轉台R��6/   ��54     .*注意：打勾即顯示，默認都打勾��6X   ��57     用戶管理��6/   ��58     
序號��6/   ��59     	登錄名��6)   ��5:     
角色��6"   ��5;     創建時間��6-   ��5<     
操作��6'   ��5?     1-表面張力計算必須導入試驗模板！��6s   ��5B     版權聲明��63   ��5C     ��廣東北斗精密儀器有限公司擁有CAPSTV1.0軟件的所有知識產權，本計算機程序受版本發/著作權法和國際公約保護， 未經書面授權擅自傳播本程序的部分或者全部可能遭受嚴厲的民事及刑事制裁。并將在法律允許的範圍内受到最大可能的起訴。��5D  {   ��5H     聯係我們��6*   ��5I     ($廣東北斗精密儀器有限公司��6U   ��5J     
電話��6'   ��5K     
傳真��6!   ��5L     
網址��6%   ��5O     #表界面測量系統Version1.0��6Z   ��5Q     樣品名稱��6/   ��5R     ≤測量平均值≤��60   5S     