   M S B A M L   `   `   `  ����>  :CRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CRMCRM  5   	       CRM.register   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:CRM     5   	     � Title$  register��5   	   $	��330��6   $	��460��6'   .��5	      � $��
0,0,0,-0.6q�6    � ColumnDefinitions 5
   
   �� 5      $
��105* �6   �� 5      $
��121* �6   .+�5   
   �� -   5         ��Name$ FirstNameET��5      $
��Left=�6'   $��23��6B   $��83.6,0,-0.2,0q�6N    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��159��6�   $��1��6�   6�   �� 5   
   -   5        $ 
LastNameET��5      $
��Left=�6&   $��23��6A   $��83.6,28,-0.2,0q�6M   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��159��6�   $��1��6�   6�   �� 5   
   -   5        $ 
NicknameET��5      $
��Left=�6&   $��23��6A   $��83.6,56,-0.2,0q�6M   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��159��6�   $��1��6�   6�   �� 5   
   -   5        $ DelET��5      $
��Left=�6!   $��23��6<   $��50.4,84,0,0q�6H   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��105��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ DelCOMBO��5      $
��Left=�6%   $��157.4,84,0,0q�6@   $	��Top=�6V   $��85��6n   $��2��6y   .@�5      �� .��6   	HOME/BASE6&   �� 5      .��6   	CELLPHONE6&   5      �� 5   
   -   5        $ Del2ET��5      $
��Left=�6"   $��23��6=   $��50.4,112,0,0q�6I   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��105��6�   $��1��6�   6�   �� 5   
   -   5        $ 	Del2COMBO��5      $
��Left=�6&   $��157.4,114,0,0q�6A   $	��Top=�6X   $��85��6p   $��2��6{   .@�5      �� .��6   	HOME/BASE6&   �� 5      .��6   	CELLPHONE6&   5      �� 5   
   -   5        $ EmailET��5      $
��Left=�6#   $��23��6>   $��
60,142,0,0q�6J   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��392��6�   $��2��6�   6�   �� 5   
   -	   5        $ 	addressET��5      $
��Left=�6%   $��45��6@   $��61,170,-0.2,0q�6L   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��392��6�   $��2��6�   6�   �� 5   
   -
   5        $ 
describtET��5      $
��Left=�6&   $��45��6A   $��61,215,-0.2,0q�6M   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��392��6�   $��2��6�   6�   �� 5   
   -   5         ��Name$ SaveBtn��5      $
��Save��6"   $
��Left=�61   $��131.6,265,0,0q�6L   $	��Top=�6c   $	��100��6{   $��31��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ label��5      $��	Describe:��6   $
��Left=�63   $��
-3,215,0,0q�6N   $	��Top=�6b   �� 5    
   -   5        $ 
label_Copy��5       $��Address:��6$   $
��Left=�67   $��
-3,170,0,0q�6R   $	��Top=�6f   �� 5!   
   -   5        $ label_Copy1��5!      $��Email:��6%   $
��Left=�66   $��
-3,140,0,0q�6Q   $	��Top=�6e   �� 5"   
   -   5        $ label1��5"      $
��Del2��6    $��1��6/   $
��Left=�6?   $��5.6,111,0,0q�6Z   $	��Top=�6o   �� 5#   
   -   5        $ label11��5#      $	��Del��6!   $��1��6/   $
��Left=�6?   $��11.6,85,0,0q�6Z   $	��Top=�6o    J� RenderTransformOrigin$ 
1.875,0.82&�6�   �� 5$   
   -   5        $ label11_Copy��5$      $��Nickname��6&   $��1��69   $
��Left=�6I   $��11.6,56,0,0q�6d   $	��Top=�6y   $ 
1.875,0.82&�6�   �� 5%   
   -   5        $ label11_Copy1��5%      $��	Last Name��6'   $��1��6;   $
��Left=�6K   $��11.6,25,0,0q�6f   $	��Top=�6{   $ 
1.875,0.82&�6�   �� 5&   
   -   5        $ label11_Copy2��5&      $��
First Name��6'   $��1��6<   $
��Left=�6L   $��11.6,-3,0,0q�6g   $	��Top=�6|   $ 
1.875,0.82&�6�   5(      5)      