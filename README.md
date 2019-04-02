# Stock
04.02(화)
 
[1] Void OnReceiveTrData Tran 수신시 이벤트
  [이벤트 처리] 
  axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;
  public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
  {
    if (e.sRQName == "종목정보요청")  //tr
    {
    long stockPrice=long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim().Replace("-",""));
    string stockName=axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
    long upDown=long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim());
    long volume=long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량").Trim());
    string upDownRate=axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim();

    stockPriceLabel.Text=String.Format("{0:#,###}", stockPrice);
    }
  }
  [이벤트 받기]
  axKHOpenAPI1.SetInputValue("종목코드", stockCode);
  axKHOpenAPI1.CommRqData("종목정보요청","opt10001",0,"5000");

[2]Void OnReceiveRealData 실시간 시세 이벤트
  [이벤트 처리]
  axKHOpenAPI1.OnReceiveRealData += onReceiveRealData;
  public void onReceiveRealData(object sender , AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
  {
    axKHOpenAPI1.GetCommRealData(종목코드, Fid번호);
  }
  [이벤트 받기]
  axKHOpenAPI1.SetInputValue("종목코드", stockCode);
  axKHOpenAPI1.CommRqData("종목정보요청","opt10001",0,"5000");

[3] Void OnReceiveMsg 수신 메시지 이벤트
  이벤트 사용용도 : 주문 처리 오류 시 메시지 출력
  이벤트 등록방법 :axKHOpenAPI1.OnReceiveMsg  += OnReceiveMsg;
  [이벤트 처리]   
  private void OnReceiveMsg(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEvent e)
  {
    _Log("ScreenNum : " + e.sScrNo + ",사용자구분명 : " + e.sRQName + ", Tr이름: " + e.sTrCode + ", MSG : " + e.sMsg );
  }


[4] Void OnReceiveChejanData 주문 접수/확인 수신시 이벤트
  이벤트 사용용도 : 주문 접수 및 체결 정보, 주신잔고
  이벤트 등록방법 : axKHOpenAPI1.OnReceiveChejanData += onReceiveChejanData;
  [이벤트 처리]
    public void onReceiveChejanData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
        {
            if (e.sGubun=="0")//주문 접수 , 체결시
            { 
              axKHOpenAPI1.GetChejanData(RealType-주문체결.PID);
	    }
            else if (e.sGubun=="1")//국내주식 잔고전달
            {
            }

[5] Void OnEventConnect 통신 연결 상태 변경시 이벤트
  [이벤트 정의]
  [이벤트 받기]


[6] void OnReceiveRealCondition 조건검색 실시간 편입,이탈종목 이벤트
  [이벤트 정의]
  [이벤트 받기]
[7] void OnReceiveTrCondition 조건검색 조회응답 이벤트
  [이벤트 정의]
  [이벤트 받기]
[8] Void OnReceiveConditionVer 로컬에 사용자조건식 저장 성공여부 응답 이벤트
  [이벤트 정의]
  [이벤트 받기]



03.20 (수)
1. MSSQL DB 생성
   - 생성 방법 : https://server-talk.tistory.com/248

03.19 (화)
1. MSSQl DB
   - 설치 방법 : https://excelsior-cjh.tistory.com/174
   
2. 싱글톤 패턴 제네릭 구현
   - 소스 코드 : http://lab.gamecodi.com/board/zboard.php?id=GAMECODILAB_QnA_etc&page=1&sn1=&divpage=1&sn=off&ss=on&sc=on&select_arrange=headnum&desc=asc&no=2393
3. TextBox 검색 목록 
   - 소그 코드 : https://www.c-sharpcorner.com/UploadFile/33b051/autocomplete-textbox-in-windows-form/
03.15 (금)
1. UI Source
  - 아이콘 이미지 : https://icons8.com/app/


03.14 (목)
[남은 구현 항목]
1. 화면 구현
   - 사용할 Winform UI 라이브러리 선택 (=MetroUI)
     1. MetroUI (무료) : https://untitledtblog.tistory.com/112   
     2. BuniFu  (유료) : https://codango.com/c-vb-net-finance-manager-modern-dark-flat-ui-bunifu-ui/#.XIsqLiIzaUk
   - 폼 분할
2. 기능 구현
   - DB 연동(빠른 검색)
   - 잔고 조회 (필요한 데이터 살펴보기)
   - 종목 조회 (필요한 데이터 살펴보기)
   - 호가창    (필요한 데이터 살펴보기)
   - 매수 주문 (필요한 데이터 살펴보기)
   - 매도 주문 (필요한 데이터 살펴보기)
   .....
  
