ComPort 轉 ComPort
==================

![ComPort_Bridge](ComPort_Bridge.png)

【程式源由】
----------
* 最近剛上手 Arduino 利用 RS-485 接收資訊，過程中需要拔掉 RS-485 後上傳程式完畢再接回去。
* 由於實在太煩人，就構思由電腦接 RS-485 再由程式橋接至與 Arduino 相連的 UART。
* 要上傳程式時停用橋接，上傳完畢啟動橋接。
