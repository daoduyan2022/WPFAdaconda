   M S B A M L   `   `   `  ????C  ?Adaconda, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Adaconda.ViewAdaconda.View  5   	   "    Adaconda.View.HardWareConfig   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Adaconda.View     5   	     ? Title$  HardWareConfig??5   	   $	??600??6    $	??800??6-   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??1* ?6   ?? 5      $	??10* ?6   .+?5   
   ? $??0??6   .+?5      ?? .+?5      o? -   5         o?Name$ 	MenuStrip??5      $??12(?6*   $	??Top=?68   
?????w?.@?5      m? $
??Menu??6   
???????.@?5      m? -   5        $??exitHardWareConfig??5   1   $
??Exit??6#    m? Icon 5      ?? 5   "   $??..\Resource\Icon\exit.png??6(   5      5      m? 5      $
??Help??6   
???????.@?5      m? $??Manual??6#   m? 5      $??Version??6#   5      5      c? 5      
?????w?.@?5       ?? -   5        $??btnIOConfig??5       $??30??60   $??30??6;    ? ToolTip$ Save, Ctrl+s??6G   .??5!      ?? $??\Resource\Icon\save.png??6    $??29??6A   $??30??6L   $??	-3,-3,0,0q?6X   $
 Save??6k   5"      5#      5$      5&      ? 5'   
   $??1??6    ? ColumnDefinitions 5(      ?? 5)      $??1* ?6#   ?? 5*      $??1* ?6#   .+?5,      ? $??0??6    5-      ?? 5.      $??1* ?6$   .+?50      ? $??0??6   .+?51      ?? $
??PLCs??6   
???????$??2q?6@   $
??Bold"?6T   .??52      ?? .+?53      ?? $??PLC1:??6$   ?? 54      $
??Left=?6)   .+?55   "   ??  ?? Orientation$ 
Horizontal=?6-   $??	10,10,0,0q?6F   .+?56   &   ?? $	??IP:??6,   ?? 57   &   -   5        $??	tbxIpPlc1??57   .   $	??150??6?   $??13,0,0,0q?6K   58   #   ?? 59   "   $ 
Horizontal=?6-   $??	10,10,0,0q?6F   .+?5:   &   ?? $??Port:??6,   ?? 5;   &   -   5        $??tbxPortPlc1??5;   .   $	??150??6A   5<   #   ?? 5=   "   -   5        $??btnCheckCntPLC1??5=   )   $??Check Connection PLC1??6@   $	??150??6`   $??25??6l   $??	46,10,0,0q?6x   ??6?   ?? * _mainWindow._StatusConnectPLC1+5>   )   5?      ?? 5A      $??PLC2:??6$   ?? 5B      $
??Left=?6)   .+?5C   "   ?? $ 
Horizontal=?6-   $??	10,10,0,0q?6F   .+?5D   &   ?? $	??IP:??6,   ?? 5E   &   -   5        $??	tbxIpPlc2??5E   .   $	??150??6?   $??13,0,0,0q?6K   5F   #   ?? 5G   "   $ 
Horizontal=?6-   $??	10,10,0,0q?6F   .+?5H   &   ?? $??Port:??6,   ?? 5I   &   -   5        $??tbxPortPlc2??5I   .   $	??150??6A   5J   #   ?? 5K   "   -	   5        $??btnCheckCntPLC2??5K   )   $??Check Connection PLC2??6@   $	??150??6`   $??25??6l   $??	46,10,0,0q?6x   ??5L   )   ?? * _mainWindow._StatusConnectPLC2+5O      ?? 5Q      $??PLC3:??6$   ?? 5R      $
??Left=?6)   .+?5S   "   ?? $ 
Horizontal=?6-   $??	10,10,0,0q?6F   $
??Left=?6Y   .+?5T   &   ?? $	??IP:??6,   ?? 5U   &   -
   5        $??	tbxIpPlc3??5U   .   $	??150??6?   $??13,0,0,0q?6K   5V   #   ?? 5W   "   $ 
Horizontal=?6-   $??	10,10,0,0q?6F   .+?5X   &   ?? $??Port:??6,   ?? 5Y   &   -   5        $??tbxPortPlc3??5Y   .   $	??150??6A   5Z   #   ?? 5[   "   -   5        $??btnCheckCntPLC3??5[   )   $??Check Connection PLC3??6@   $	??150??6`   $??25??6l   $??	46,10,0,0q?6x   ??5\   )   ?? * _mainWindow._StatusConnectPLC3+5_      ?? 5a      $??PLC4:??6$   ?? 5b      $
??Left=?6)   .+?5c   "   ?? $ 
Horizontal=?6-   $??	10,10,0,0q?6F   .+?5d   &   ?? $	??IP:??6,   ?? 5e   &   -   5        $??	tbxIpPlc4??5e   .   $	??150??6?   $??13,0,0,0q?6K   5f   #   ?? 5g   "   $ 
Horizontal=?6-   $??	10,10,0,0q?6F   .+?5h   &   ?? $??Port:??6,   ?? 5i   &   -   5        $??tbxPortPlc4??5i   .   $	??150??6A   5j   #   ?? 5k   "   -   5        $??btnCheckCntPLC4??5k   )   $??Check Connection PLC4??6@   $	??150??6`   $??25??6l   $??	46,10,0,0q?6x   ??5l   )   ?? * _mainWindow._StatusConnectPLC4+5m      5n      5p      5q      5r      ? 5s      $??1??6    5t      ?? 5u      $??4* ?6$   ?? 5v      $??2* ?6$   ?? 5w      $??1* ?6$   .+?5y      ? $??0??6   .+?5z      ?? $??Camera??6   
???????$??2q?6B   $
??Bold"?6V   .??5{      ?? .+?5|      ?? $??	Camera 1:??6$   ?? 5}      $ 
Horizontal=?6)   $??10,0,0,0q?6B   .+?5~   "   ?? $??Pixel to mm:??6(   $??Normal"?6?   ?? 5   "   -   5        $??txtPixelToMm1??5   *   $	??150??6?   $??13,0,0,0q?6K   5?      ?? 5?      $??	Camera 2:??6$   ?? 5?      $ 
Horizontal=?6)   $??10,0,0,0q?6B   .+?5?   "   ?? $??Pixel to mm:??6(   $??Normal"?6?   ?? 5?   "   -   5        $??txtPixelToMm2??5?   *   $	??150??6?   $??13,0,0,0q?6K   5?      ?? 5?      $??	Camera 3:??6$   ?? 5?      $ 
Horizontal=?6)   $??10,0,0,0q?6B   .+?5?   "   ?? $??Pixel to mm:??6(   $??Normal"?6?   ?? 5?   "   -   5        $??txtPixelToMm3??5?   *   $	??150??6?   $??13,0,0,0q?6K   5?      ?? 5?      $??	Camera 4:??6$   ?? 5?      $ 
Horizontal=?6)   $??10,0,0,0q?6B   .+?5?   "   ?? $??Pixel to mm:??6(   $??Normal"?6?   ?? 5?   "   -   5        $??txtPixelToMm4??5?   *   $	??150??6?   $??13,0,0,0q?6K   5?      5?      5?      5?      ? 5?      $??1??6   .+?5?      ?? $??Light??6   
???????$??2q?6A   $
??Bold"?6U   5?      5?      5?      5?      5?      5?      