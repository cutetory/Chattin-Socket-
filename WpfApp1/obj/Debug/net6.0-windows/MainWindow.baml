   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   9!clr-namespace:WpfApp1.CustomStyleWpfApp1.CustomStyle  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5mylocal!clr-namespace:WpfApp1.CustomStyle     5   	     ? Title$  
MainWindow??5	   	   $	??300??6   $	??400??6)   $
??0.75q?65   ???	#CCCECBD0 ? 
ResizeMode$ NoResize=?6d    ? 	Resources 5
         Test001  testchk ?? Triggers ?? Binding ?? ElementName ?? Path ?? Value ?? Property	 ?? Value  passchk
 ?? 
TargetType ?? 
TargetType ??Name ?? CornerRadius ?? Padding ?? Color'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState ??Name  testMyButton??%X  &	        &	 !     &	 ?     &	 ?    ??5   
   	#FFE8EDF9??6+   ?? 5   
    5      ?? 5       6   ?? $ chkSave??$ 	IsChecked? True6V   .a?5      ?? 	prpchk001?? ? {?$	 False??6R   ?? 5       ? ??	 ?	#FFABADB36;   5      5      ?? 5   
   "
 G?6    .?5'      ?? tmpTest?? ? ??	 5(      ?? 5)      " G?6&   .R?5*      ?? $ pwBorder??6!   $ 3??63   $ 3q?6D   $??1q?6P   ??5+      ?? 5,   "   $ #FFFFFF??62   ??5.      ?? 5/   "   $ 	#FFABADB3??62    52        53   "   CommonStates??. 54   &     
Normal??62     55   &   Disabled??62     56   &   	MouseOver??62   57   #   ._?59      ?? $ PART_ContentHost??6+   5:      5;      5=       5>      ?? 5?       6   ?? $ chkSave??$ 	IsChecked? True6V   .a?5@      ?? 	prpchk001?? ? {?$	 False??6R   5A      5C      ?? 5D   
   "
 ??6%   .?5E      ??  ?@J?SnapsToDevicePixels$
	 True??64   ?? 5F       ?@?OverridesDefaultStyle$
	 True??66   ?? 5G       ?@?FocusVisualStyle	 61   Z? ?? 5H       ? ??$	 23??6*   ?? 5I       ? ??$	 75??6)   ?? 5K       ? ??	 5L      ?? 5M      chkSave??" ??67   .R?5N      ?? $??/직인연습5.png??6    5O      5Q       5R      5W      5X      ??5Y      ?? 5Z   
   $ 	#FFFEFFF1??6    ?? Opacity$ 1Q?6,   .??5\      ? .+?5]   
   ?? -   5         ??Name$ lblTitle??5]      $ ??StringTalk 로그인화면??6"   $??83,27,64,195q?6=   $
??Bold"?6S   $??20(?6e   $	??251??6s   $??60.54??6   ?? 5^   
   $??	아이디??6   $
??Left=?6   $??
109,93,0,0q?69   $	??Top=?6M    J? RenderTransformOrigin$ -0.659,0.528&?6e   ?? 5_   
   -   5         ??Name$ txtID??5_      $
??Left=?6!   $??
170,93,0,0q?6<    ?? TextWrapping$
 Wrap=?6P   $?? ??6d   $	??Top=?6l   $	??120??6?   $??3q?6?   $??23.96??6?   #??[ 6?   .??6?    5`      ??%d   '??       ?? 5a      "
 ??6   .?5b      ??  ?@??CornerRadius$	 3,3,3,3??65   5c      5d      .??6!   5e      ?? 5f   
   $	??P/W??6   $
??Left=?6   $??115,137,0,0q?69   $	??Top=?6N   G? 5g   
   -   5         G?Name$
 pbPW??5g      $
??Left=?6$   $??170,137,0,0q?6?   $	??Top=?6T   $	??120??6l   $	??0.5q?6x   $??24??6?   #??[ 6?   ?? 5h   
   -   5         ??Name$ chkSave??5h      $??아이디, p/w 저장??6$   $??115,168,152,74q?6:   $??131.5??6R   $??40.54??6`   6o   ?? 5i   
   $?? ??6   $
??Left=?6   $??297,210,0,0q?67   $	??Top=?6L   $??50??6d   $??50??6o   #??[ 6{   ??6?   ?? *	TestClick+? 5j   
   $
??Left=?6   $??15??61   $??
90,245,0,0q?6=   $	??Top=?6Q   $	??200??6i    ? Value 6u   ?? *M_ProgressValue+?? 5k   
   $??소켓연결??6   $
??Left=?6    $??314,121,0,0q?6;   $	??Top=?6P   ??6h   ?? *TestSocketClick+?? 5l   
   -   5        $ txtFire??5l      $
??Left=?6#   $??
33,199,0,0q?6>   $
 Wrap=?6R   $??TextBox??6f   $	??Top=?6u   $	??120??6?   ?? 5m   
   -   5         ??Name$ btnFireTest??5m      $??Button??6&   $
??Left=?67   $??168,199,0,0q?6R   $	??Top=?6g   6   5n      5o      