   M S B A M L   `   `   `  ����P  LUrnikGooG_AdminClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:UrnikGooG_AdminClientUrnikGooG_AdminClient  5   	   &     UrnikGooG_AdminClient.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:UrnikGooG_AdminClient     5   	     � Title$  GooGUrnik-Admin-View��5   	   $	��800��6&   $
��1300��63   .��5	      � -   5        $��
GridMaster��5	      .+�5
   
   � -   5        $��Grid_Urejanje��5
      .+�5      �� -   5        $��TabControlMaster��5      .@�5      �� -   5        $��TabItem_MesečniUrnik��5      $��Mesečni urniki��66   5      �� 5      -   5        $��TabItem_Zaposleni��5      $��	Zaposleni��63   .��5      � -   5        $��Grid_zaposleniControl��5      .+�5      � $��	0,0,800,0q�6   .+�5      �� -   5        $��TabControl_Zaposleni��5   )   .@�5   "   �� -   5        $!��TabItem_Poizvedbe_Zaposleni��5   *   $��	Poizvedbe��6M   .��5   &   � -	   5        $��Grid_Poizvedbe_Zaposleni��5   +   $	��Top=�6K   $	��270��6c   .+�5   *   �� -
   5        $ ��button_Zaposleni_IzberiVse��5   1   $��
Izberi vse��6S   $��20��6h   $��14,15,371,235q�6�   �� 5   *   -   5         ��Name$% textBox_Zaposleni_IščiPoImenu��5   2   $
��Left=�6Y   $��23��6t   $��
139,70,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $��TextBox��6�   $	��Top=�6�   $	��120��6�   �� 5   *   -   5         ��Name$$ button_Zaposleni_IščiPoImenu��5   1   $��Išči��6W   $
��Left=�6f   $��
274,70,0,0q�6�   $	��Top=�6�   $��75��6�   $��25��6�   6�   �� 5   *   -   5         ��Name$ comboBox_iščiPo��5   3   $
��Left=�6L   $��4,70,0,0q�6g   $	��Top=�6y   $	��120��6�   5   '   5   #   �� 5   "   -   5        $��TabItem_Dodaj_Zaposleni��5   *   $��Dodaj��6I   .��5   &   � -   5        $��Grid_Dodaj_Zaposleni��5   +    � ColumnDefinitions 5   *   �� 5   .   $	��89* �6?   �� 5    .   $
��391* �6?   .+�5"   *   �� -   5         ��Name$ 	label_Ime��5"   0   $	��Ime��6C   $
��Left=�6Q   $��	59,35,0,0q�6l   $	��Top=�6   �� 5#   *   -   5        $ label_Priimek��5#   0   $��Priimek��6G   $
��Left=�6Y   $��	39,65,0,0q�6t   $	��Top=�6�    J� RenderTransformOrigin$ 0.132,1.346&�6�   �� 5$   *   -   5        $ label_Emšo��5$   0   $��Emšo��6D   $
��Left=�6S   $��	50,95,0,0q�6n   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5%   *   -   5        $ label_Davčna��5%   0   $��Davčna številka��6F   $
��Left=�6`   $��
-2,125,0,0q�6{   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5&   *   -   5        $ label_UrnaPostavka��5&   0   $��Urna postavka��6L   $
��Left=�6d   $��	3,155,0,0q�6   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5'   *   -   5        $ textBox_Ime��5'   2   $��1��6G   $
��Left=�6W   $��23��6r   $��	10,32,0,0q�6~   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5(   *   -   5        $ textBox_Priimek��5(   2   $��1��6K   $
��Left=�6[   $��23��6v   $��	10,62,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5)   *   -   5        $ textBox_Emšo��5)   2   $��1��6H   $
��Left=�6X   $��23��6s   $��	10,90,0,0q�6   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5*   *   -   5        $ textBox_DavčnaŠtevilka��5*   2   $��1��6R   $
��Left=�6b   $��23��6}   $��
10,122,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5+   *   -   5        $ textBox_UrnaPostavka��5+   2   $��1��6P   $
��Left=�6`   $��23��6{   $��
10,152,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5,   *   -   5        $ button_Dodaj��5,   1   $��2��6G   $��Dodaj��6[   $
��Left=�6�   $��
54,190,0,0q�6�   $	��Top=�6�   $��75��6�   5.   '   5/   #   �� 50   "   -   5        $��TabItem_Osveži_Zaposleni��50   *   $��Osveži��6J   .��51   &   � -   5        $��Grid_Osveži_Zaposleni��51   +    52   *   �� 53   .   $	��89* �6?   �� 54   .   $
��391* �6?   .+�56   *   �� -   5        $ labelOsveži_Ime��56   0   $	��Ime��6I   $
��Left=�6W   $��	59,35,0,0q�6r   $	��Top=�6�   �� 57   *   -   5        $ labelOsveži_Priimek��57   0   $��Priimek��6M   $
��Left=�6_   $��	39,65,0,0q�6z   $	��Top=�6�   $ 0.132,1.346&�6�   �� 58   *   -   5        $ labelOsveži_Emšo��58   0   $��Emšo��6J   $
��Left=�6Y   $��	50,95,0,0q�6t   $	��Top=�6�   $ 0.132,1.346&�6�   �� 59   *   -    5        $ labelOsveži_Davčna��59   0   $��Davčna številka��6L   $
��Left=�6f   $��
-2,125,0,0q�6�   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5:   *   -!   5        $ labelOsveži_UrnaPostavka��5:   0   $��Urna postavka��6R   $
��Left=�6j   $��	3,155,0,0q�6�   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5;   *   -"   5        $ textBoxOsveži_Ime��5;   2   $��1��6M   $
��Left=�6]   $��23��6x   $��	10,32,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5<   *   -#   5        $ textBoxOsveži_Priimek��5<   2   $��1��6Q   $
��Left=�6a   $��23��6|   $��	10,62,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5=   *   -$   5        $ textBoxOsveži_Emšo��5=   2   $��1��6N   $
��Left=�6^   $��23��6y   $��	10,90,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5>   *   -%   5        $% textBoxOsveži_DavčnaŠtevilka��5>   2   $��1��6X   $
��Left=�6h   $��23��6�   $��
10,122,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5?   *   -&   5        $! textBoxOsveži_UrnaPostavka��5?   2   $��1��6V   $
��Left=�6f   $��23��6�   $��
10,152,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5@   *   -'   5        $ buttonOsveži_Dodaj��5@   1   $��2��6M   $��Posodobi��6a   $
��Left=�6�   $��
54,190,0,0q�6�   $	��Top=�6�   $��75��6�   �� 5A   *   -(   5        $ comboBox_ZaposleniIzberi��5A   3   $��1��6U   $
��Left=�6e   $��
185,30,0,0q�6�   $	��Top=�6�   $	��120��6�   6�   �� 5B   *   -)   5        $ labeIzberiZaposlenega��5B   0   $��Izberi zaposlenega:��6O   $��1��6m   $
��Left=�6}   $��	185,0,0,0q�6�   $	��Top=�6�   5D   '   5E   #   �� 5F   "   -*   5        $��TabItem_Zbirši_Zaposleni��5F   *   $��Zbriši��6J   .��5G   &   � -+   5        $��Grid_Zbriši_Zaposleni��5G   +   .+�5H   *   �� -,   5        $ buttonZaposleni_Zbriši��5H   1   $��Izbriši��6Q   $
��Left=�6�   $��
104,30,0,0q�6�   $	��Top=�6�   $��75��6�   �� 5I   *   --   5        $ comboBox_ZaposleniZbriši��5I   3   $��1��6U   $
��Left=�6e   $��
185,30,0,0q�6�   $	��Top=�6�   $	��120��6�   6�   �� 5J   *   -.   5        $" label_ZaposleniIzbriši_Info��5J   0   $��
Zaposleni:��6U   $
��Left=�6j   $��8,59,0,0q�6�   $	��Top=�6�   5K   '   5L   #   5M      5N      � 5O      -/   5        $��Grid_DataGrid_Zaposleni��5O      $��Right=�6?   .+�5P      &   System.Windows.Controls.DataGrid  -0   5        $��DataGrid_Zaposleni��5P   '   $	��780��6A   5Q      5R      5S      �� 5T      -1   5        $��TabItem_Dopust��5T      $��Dopust��60   .��5U      � -2   5        $��Grid_DopustiControl��5U      .+�5V      � $��	0,0,800,0q�6   .+�5W      �� -3   5        $��TabControl_Dopusti��5W   )   .@�5X   "   �� -4   5        $��TabItem_Poizvedbe_Dopusti��5X   *   $��	Poizvedbe��6K   .��5Y   &   � -5   5        $��Grid_Poizvedbe_Dopusti��5Y   +   $	��Top=�6I   $	��270��6a   .+�5Z   *   �� -6   5        $��button_Dopusti_IzberiVse��5Z   1   $��
Izberi vse��6Q   $��20��6f   $��14,15,371,235q�6�   �� 5[   *   -7   5        $" button_Dopusti_IščiPoImenu��5[   1   $��Išči��6U   $
��Left=�6d   $��
134,70,0,0q�6   $	��Top=�6�   $��75��6�   $��25��6�   6�   �� 5\   *   -8   5        $ comboBox_iščiPo_Dopusti��5\   3   $
��Left=�6T   $��4,70,0,0q�6o   $	��Top=�6�   $	��120��6�   6�   5^   '   5_   #   �� 5`   "   -9   5        $��TabItem_Dodaj_Dopusti��5`   *   $��Dodaj��6G   .��5a   &   � -:   5        $��Grid_Dodaj_Dopusti��5a   +    5b   *   �� 5c   .   $	��89* �6?   �� 5d   .   $
��391* �6?   .+�5f   *   �� -;   5        $ label_Ime_Dopusti��5f   0   $	��Ime��6K   $
��Left=�6Y   $��	59,35,0,0q�6t   $	��Top=�6�   �� 5g   *   -<   5        $ label_Priimek_Dopusti��5g   0   $��Priimek��6O   $
��Left=�6a   $��	39,65,0,0q�6|   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5h   *   -=   5        $! label_Emšo_Dopusti_Dopusti��5h   0   $��Emšo��6T   $
��Left=�6c   $��	50,95,0,0q�6~   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5i   *   ->   5        $ label_Davčna_Dopusti��5i   0   $��Davčna številka��6N   $
��Left=�6h   $��
-2,125,0,0q�6�   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5j   *   -?   5        $  label_UrnaPostavka_Dopusti��5j   0   $��Urna postavka��6T   $
��Left=�6l   $��	3,155,0,0q�6�   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5k   *   -@   5        $ textBox_Ime_Dopusti��5k   2   $��1��6O   $
��Left=�6_   $��23��6z   $��	10,32,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5l   *   -A   5        $ textBox_Priimek_Dopusti��5l   2   $��1��6S   $
��Left=�6c   $��23��6~   $��	10,62,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5m   *   -B   5        $ textBox_Emšo_Dopusti��5m   2   $��1��6P   $
��Left=�6`   $��23��6{   $��	10,90,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5n   *   -C   5        $&  textBox_DavčnaŠtevilka_Dopusti��5n   2   $��1��6Z   $
��Left=�6j   $��23��6�   $��
10,122,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5o   *   -D   5        $" textBox_UrnaPostavka_Dopusti��5o   2   $��1��6X   $
��Left=�6h   $��23��6�   $��
10,152,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5p   *   -E   5        $ button_Dodaj_Dopusti��5p   1   $��2��6O   $��Dodaj��6c   $
��Left=�6�   $��
54,190,0,0q�6�   $	��Top=�6�   $��75��6�   5r   '   5s   #   �� 5t   "   -F   5        $��TabItem_Osveži_Dopusti��5t   *   $��Osveži��6H   .��5u   &   � -G   5        $��Grid_Osveži_Dopusti��5u   +    5v   *   �� 5w   .   $	��89* �6?   �� 5x   .   $
��391* �6?   .+�5z   *   �� -H   5        $ labelOsveži_Ime_Dopusti��5z   0   $	��Ime��6Q   $
��Left=�6_   $��	59,35,0,0q�6z   $	��Top=�6�   �� 5{   *   -I   5        $" labelOsveži_Priimek_Dopusti��5{   0   $��Priimek��6U   $
��Left=�6g   $��	39,65,0,0q�6�   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5|   *   -J   5        $  labelOsveži_Emšo_Dopusti��5|   0   $��Emšo��6R   $
��Left=�6a   $��	50,95,0,0q�6|   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5}   *   -K   5        $" labelOsveži_Davčna_Dopusti��5}   0   $��Davčna številka��6T   $
��Left=�6n   $��
-2,125,0,0q�6�   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5~   *   -L   5        $' !labelOsveži_UrnaPostavka_Dopusti��5~   0   $��Urna postavka��6Z   $
��Left=�6r   $��	3,155,0,0q�6�   $	��Top=�6�   $ 0.132,1.346&�6�   �� 5   *   -M   5        $  textBoxOsveži_Ime_Dopusti��5   2   $��1��6U   $
��Left=�6e   $��23��6�   $��	10,32,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5�   *   -N   5        $$ textBoxOsveži_Priimek_Dopusti��5�   2   $��1��6Y   $
��Left=�6i   $��23��6�   $��	10,62,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5�   *   -O   5        $" textBoxOsveži_Emšo_Dopusti��5�   2   $��1��6V   $
��Left=�6f   $��23��6�   $��	10,90,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5�   *   -P   5        $- 'textBoxOsveži_DavčnaŠtevilka_Dopusti��5�   2   $��1��6`   $
��Left=�6p   $��23��6�   $��
10,122,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5�   *   -Q   5        $) #textBoxOsveži_UrnaPostavka_Dopusti��5�   2   $��1��6^   $
��Left=�6n   $��23��6�   $��
10,152,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5�   *   -R   5        $! buttonOsveži_Dodaj_Dopusti��5�   1   $��2��6U   $��Posodobi��6i   $
��Left=�6�   $��
54,190,0,0q�6�   $	��Top=�6�   $��75��6�   �� 5�   *   -S   5        $&  comboBox_ZaposleniIzberi_Dopusti��5�   3   $��1��6]   $
��Left=�6m   $��
185,30,0,0q�6�   $	��Top=�6�   $	��120��6�   6�   �� 5�   *   -T   5        $# labeIzberiZaposlenega_Dopusti��5�   0   $��Izberi zaposlenega:��6W   $��1��6u   $
��Left=�6�   $��	185,0,0,0q�6�   $	��Top=�6�   5�   '   5�   #   �� 5�   "   -U   5        $��TabItem_Zbirši_Dopusti��5�   *   $��Zbriši��6H   .��5�   &   � -V   5        $��Grid_Zbriši_Dopusti��5�   +   .+�5�   *   �� -W   5        $ buttonDopusti_Zbriši��5�   1   $��Izbriši��6O   $
��Left=�6�   $��
104,30,0,0q�6�   $	��Top=�6�   $��75��6�   �� 5�   *   -X   5        $ comboBox_DopustiZbriši��5�   3   $��1��6S   $
��Left=�6c   $��
185,30,0,0q�6~   $	��Top=�6�   $	��120��6�   6�   �� 5�   *   -Y   5        $  label_DopustiIzbriši_Info��5�   0   $��
Zaposleni:��6S   $
��Left=�6h   $��8,59,0,0q�6�   $	��Top=�6�   5�   '   5�   #   5�      5�      � 5�      -Z   5        $��Grid_DataGrid_Dopust��5�      $��Right=�6<   .+�5�        -[   5        $��DataGrid_Dopust��5�   '   $	��780��6>   5�      5�      5�      �� 5�      -\   5        $��TabItem_Bolniška��5�      $��	Bolniška��62   .��5�      � -]   5        $��Grid_DataGrid_Bolniska��5�      $��Right=�6:   .+�5�        -^   5        $��DataGrid_Bolniska��5�   #   $	��780��6<   5�      5�      �� 5�      -_   5        $��TabItem_Izmena��5�      $��Izmena��60   .��5�      � -`   5        $��Grid_DataGrid_Izmena��5�      $��Right=�68   .+�5�        -a   5        $��DataGrid_Izmena��5�   #   $	��780��6:   5�      5�      �� 5�      -b   5        $��TabItem_Opravilo��5�      $��Opravilo��62   .��5�      � -c   5        $��Grid_DataGrid_Opravilo��5�      $��Right=�6:   .+�5�        -d   5        $��DataGrid_Opravilo��5�   #   $	��780��6<   5�      5�      �� 5�      -e   5        $��TabItem_ProstiDan��5�      $��Prosti dnevi��63   .��5�      � -f   5        $��Grid_DataGrid_ProstiDan��5�      $��Right=�6;   .+�5�        -g   5        $��DataGrid_ProstiDan��5�   #   $	��780��6=   5�      5�      5�      5�      5�      5�      