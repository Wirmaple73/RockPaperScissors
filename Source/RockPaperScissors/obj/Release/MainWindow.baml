   M S B A M L   `   `   `  ����   RockPaperScissors"    RockPaperScissors.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Rock Paper Scissors��$	��380��$	��320��&   System.Windows.Media.TextOptions   TextFormattingMode$ Display=� � 
ResizeMode$ CanMinimize=� � SizeToContent$ Width=� � Icon$ icon.ico��.��� .+��� -    ��Name$ TextBlock_RoundNum��$
��Left=�$��	53,29,0,0q�$
��Wrap=�$��Round 0��$	��Top=�$��15(� �� TextAlignment$ Center=�$	��208���� -    ��Name$ CBox_PlayerChoice��$��	22,89,0,0q�$	��Top=�$��89�� �� SelectedIndex$ 0��	 �� MaxDropDownHeight$
	 1024��
 � ToolTip$
 Select one.��$
��Left=�$��98��.@��� .���� $��Resources/rps_rock.png��$��84��$
 Rock (Shortcut: R)���� .���� $��Resources/rps_paper.png��$��80��$
 Paper (Shortcut: P)���� .���� $ ��Resources/rps_scissors.png��$��80��$
 Scissors (Shortcut: S)���� -    ��Name$ Image_Opponent��$��89��$��196,89,18,0q�$	��Top=�$��Resources/rps_unknown.png��$
 CPU's choice.���� $	��You��$
��Left=�$��	55,62,0,0q�$	��Top=��� $	��CPU��$
��Left=�$��
228,62,0,0q�$	��Top=��� -    ��Name$ Label_PlayerScore��$��0��$
��Left=�$��Center=�$��
24,183,0,0q�$	��Top=�$��98��$��26(�$
 Your score.���� -   $ Label_OpponentScore��$��0��$
��Left=�$��Center=�$��195,183,0,0q�$	��Top=�$��98��$��26(�$
 CPU's score.���� $��-��$��Center=�$��145,172,0,0q�$	��Top=�$��40(�$
��Left=��� -   $ Label_Winner��$��Center=�$��
93,235,0,0q�$	��Top=�$��24(�$��41��$
��Left=�$	��128���� -   $
��Play��$��
24,289,0,0q�$	��Top=�$��34�� �� 	IsDefault . $
 Try your chance.��$
��Left=�$	��110���� -	   $��Reset��$��180,289,0,0q�$	��Top=�$��34�� �� IsCancel . $,
 &Reset the scores and start a new game.��$
��Left=�$	��110��o� $
��Left=�$��24��$	��Top=�$	��314��.@�m� $��_File��.@�m� -
   $��_Exit��m� $��_Help��.@�m� -   $��_About��