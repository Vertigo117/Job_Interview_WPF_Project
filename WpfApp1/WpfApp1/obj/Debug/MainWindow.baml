   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5        $��Main_Window��5   &     � Title$  
MainWindow��5   	   $��14(�6   ���#04c582$	��500��6@   $	��800��6M    � 	Resources 5	         WpfApp1.Database1DataSet   database1DataSet  sTUFFViewSource �� Source �� Source��%V   &	        &	      7     5
   
   6!   �� 5   
    67   �� *STUFF+8   5      .��5      �� ���#2e3137$��10q�6"    �� CornerRadius$ 20��6.   ._�5   
   �  � DataContext# [ 6    � ColumnDefinitions 5      �� 5      .+�5      �� $��Products��6   
�������$��25(�6:   $��Center=�6H   $��328,0,332,0q�6e   $	��112��6z   �� 5      $	��Top=�6   $��
40,40,40,0q�60   &   System.Windows.Controls.DataGrid  5      -   5          Name$ sTUFFDataGrid��5      ���#545d6a   AutoGenerateColumns .  	   EnableRowVirtualization	 . $��22,60,22,70q�6�   
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�6�      AlternatingRowBackground �#04c582$ �� IsSynchronizedWithCurrentItem$
 TrueY�6*   �� IsTextSearchEnabled . ��6   �� # [    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        sTUFF_IDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5   ^      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *
STUFF_ID+6j     5      -   5        sTUFF_NAMEColumn��$
 Name��5   b    6C   �� *
STUFF_NAME+6b     5      -   5        sTUFF_PRICEColumn��$ Price��5   d    6D   �� *STUFF_PRICE+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        dATE_FROMColumn��$ 	Date From��5   F      CellTemplate 5      �� 5      .R�5   "   (  "System.Windows.Controls.DatePicker     SelectedDate 6-   �� *	DATE_FROM+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5!        5"      -   5        dATE_TOColumn��$ Date To��5"   D    5#      �� 5$      .R�5%   "      6-   �� *	DATE_TO+$ TwoWay=� .  . 5&      5(      5*      �� 5+      -   5        $��	btnUpdate��5+      ���#545d6a
�������$��Update��6N   $��Right=�6_   $��
0,0,256,24q�6{   $��76��6�   $��Bottom=�6�   �� 5,      -	   5        $��Insert��5,      ���#545d6a
�������$��
0,0,444,24q�6N   $��Bottom=�6b   $��Right=�6�   $��76��6�   5-      5.      5/      