   M S B A M L   `   `   `  ����E  AClubMember, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ClubMember
ClubMember  5          ClubMember.PaymentCCPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:ClubMember     5         	PageStyle#��[  5        N� Title$  PaymentCCPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��104* �6   �� 5      $
��571* �6   .+�5   
   �� -   5         ��Name$ 
CreditCard��5        WhiteBoldButtonStyle#��[ 6%   $��Credit Card��6S   $
��Left=�6i   $��48,0,0,0q�6�   $��Center=�6�   $��31��6�   $	��140��6�   �� 5   
   -   5        $ Paypal��5      #��[ 6!   $��	188,0,0,0q�6O   $��Center=�6b   $��31��6}   $	��140��6�   $
��Left=�6�   .��5      �� $��Paypal��6   5      �� 5   
   $
��Left=�6   $��5��6/   $��	48,62,0,0q�6:   ���	#FF7D888F$	��Top=�6`   $	��140��6x   ���	#FF7D888F6�   �� 5   
     WhiteRectangleStyle#��[ 6   $��Center=�6A   $��84��6^   $��0,20,0,0q�6j   $	��Top=�6|   $	��281��6�   $��1��6�   �� 5   
   $��Months��6     WhiteBoldLabelStyle#��[ 6!   $��48,20,0,489q�6N   $
��Left=�6c   $	��100��6~   $��18(�6�   $��1��6�   �� 5   
   -   5         ��Name$ PricePerMonth��5      $��6€ per moth��6'   #��[ 6=   $��	47,68,0,0q�6j   $	��Top=�6}   $	��100��6�   $
��Left=�6�   $��10(�6�   ���	#FFA2A2A2$
��Bold"�6�   $��1��6�   �� 5   
   -   5        $ 
PlusSignal��5      $��+��6%     SignalBoldButtonStyle#��[ 61   $��291,41,55,0q�6`   $��22(�6u    J� RenderTransformOrigin$ 0.511,0.549&�6�   $��Stretch=�6�   $	��Top=�6�   $��28��6�   $��1��6  �� 5   
   -   5        $ MinusSignal��5      $��-��6&   #��[ 62   $��230,41,117,0q�6a   $��22(�6w   $ 0.511,0.549&�6�   $��Stretch=�6�   $	��Top=�6�   $��28��6�   $��1��6  �� 5   
   -   5        $ QuantityMonths��5      $��1��6(   #��[ 64   $��
258,42,0,0q�6a   $	��Top=�6u   $��33��6�   $
��Left=�6�   $��Center=�6�   ���	#FFA2A2A2$
��Bold"�6�   $��28��6   $��1��6  �� 5   
   $
��Left=�6   $��
48,149,0,0q�6/   $��1��6C   $��Card Details��6P   $
��Wrap=�6d   $	��Top=�6x   
�������6�   �� 5   
   #��[ 6   $��Center=�6A   $	��267��6^   $��	0,170,0,0q�6k   $	��Top=�6~   $	��281��6�   $��1��6�   �� 5   
   $��Center=�6   $��Center=�6/   $��	0,196,0,0q�6Q   $��1��6d   $��Card Number��6q    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��228��6�   ���	#FF7D888F$��38��6�   �� 5   
   $��Center=�6   $��Center=�6/   $��	0,248,0,0q�6Q   $��1��6d   $��Name on Card��6q   $
 Wrap=�6�   $	��Top=�6�   $	��228��6�   ���	#FF7D888F$��38��6�   �� 5   
   $
��Left=�6   $��Center=�6-   $��
74,308,0,0q�6O   $��1��6c   $��Expire Date (mm/yy)��6p   $
 Wrap=�6�   $	��Top=�6�   $	��114��6�   ���	#FF7D888F$��38��6�   �� 5    
   $
��Left=�6   $��Center=�6-   $��188,308,0,0q�6O   $��1��6d   $
��CCV*��6q   $
 Wrap=�6}   $	��Top=�6�   $	��114��6�   ���	#FF7D888F$��38��6�   �� 5!   
   $��Center=�6   $��	0,351,0,0q�61   $��1��6D   $U��O* Your CCV is the last 3 digits in the signature strip on the back of your card��6Q   $
��Wrap=�6�   $	��Top=�6�   $��7(�6�   $	��228��6�   ���	#FF7D888F$
��Bold"�6  �� 5"   
   $$��Do you want to save this card?��6   $
��Left=�6<   $��
74,383,0,0q�6W   $��1��6k   $	��Top=�6x   $	��220��6�   ���	#FF7D888F$��10(�6�   �� 5#   
   #��[ 6   $��Center=�6A   $��35��6^   $��	0,458,0,0q�6j   $	��Top=�6}   $	��281��6�   $��1��6�   �� 5$   
   -   5        $ PricePerMonth_Copy��5$      $��SubTotal��6,   #��[ 6?   $��
47,458,0,0q�6l   $	��Top=�6�   $	��111��6�   $
��Left=�6�   $��14(�6�   
���   �$
��Bold"�6�   $��1��6�   $��35��6�   �� 5%   
   -   5        $ SubTotalPrice��5%      $
��6€��6'   #��[ 64   $��209,458,0,0q�6a   $	��Top=�6v   $	��119��6�   $
��Left=�6�   $��14(�6�   ���	#FFA2A2A2$
��Bold"�6�   $��1��6�   $��35��6�   �� 5&   
   #��[ 6   $��Center=�6A   $��53��6^   $��	0,508,0,0q�6j   $	��Top=�6}   $	��281��6�   $��1��6�   �� 5'   
   -	   5        $ PricePerMonth_Copy1��5'      $��Total:��6-   #��[ 6>   $��	0,508,0,0q�6k   $	��Top=�6~   $	��281��6�   $��14(�6�   
���   �$
��Bold"�6�   $��1��6�   $��26��6�   �� 5(   
   -
   5        $ 
TotalPrice��5(      $��	7,38€ *��6$   #��[ 66   $
��Left=�6c   $��209,508,0,0q�6�   $	��Top=�6�   $	��119��6�   $
��Left=�6�   $��14(�6�   ���	#FFA2A2A2$
��Bold"�6�   $��1��6  $��26��6  �� 5)   
   $
��Left=�6   $��286,508,0,0q�6/   $��1��6D   $��	* IVA 23%��6Q   $
��Wrap=�6b   $	��Top=�6v   $��6(�6�   $��89��6�   ���	#FF7D888F$
��Bold"�6�   $��20��6�   �� 5*   
   -   5        $ Renew��5*        BlueBoldButtonStyle#��[ 6    $	��PAY��6M   $��	0,534,0,0q�6[   $	��Top=�6n   $	��114��6�   $��27��6�   
���   �$��1��6�   ���	#00A2A2A2���	#FFA2A2A26�   5+      5,      