BEGIN_FUNCTION_MAP
	.Func,해외선물현재가(종목정보)조회(o3105)-API용,o3105,attr,block,svr=OVS,headtype=A;
	BEGIN_DATA_MAP
	o3105InBlock,기본입력,input;
	begin
		종목코드,symbol,symbol,char,8;
	end
	o3105OutBlock,출력,output;
	begin
		종목코드,Symbol,Symbol,char,8;
		종목명,SymbolNm,SymbolNm,char,50;
		종목배치수신일,ApplDate,ApplDate,char,8;
		기초상품코드,BscGdsCd,BscGdsCd,char,10;
		기초상품명,BscGdsNm,BscGdsNm,char,40;
		거래소코드,ExchCd,ExchCd,char,10;
		거래소명,ExchNm,ExchNm,char,40;
		정산구분코드,EcCd,EcCd,char,1;
		기준통화코드,CrncyCd,CrncyCd,char,3;
		진법구분코드,NotaCd,NotaCd,char,3;
		호가단위가격,UntPrc,UntPrc,double,15.9;
		최소가격변동금액,MnChgAmt,MnChgAmt,double,15.9;
		가격조정계수,RgltFctr,RgltFctr,double,15.10;
		계약당금액,CtrtPrAmt,CtrtPrAmt,double,15.2;
		상장개월수,LstngMCnt,LstngMCnt,long,2;
		상품구분코드,GdsCd,GdsCd,char,3;
		시장구분코드,MrktCd,MrktCd,char,3;
		Emini구분코드,EminiCd,EminiCd,char,1;
		상장년,LstngYr,LstngYr,char,4;
		상장월,LstngM,LstngM,char,1;
		월물순서,SeqNo,SeqNo,long,5;
		상장일자,LstngDt,LstngDt,char,8;
		만기일자,MtrtDt,MtrtDt,char,8;
		최종거래일,FnlDlDt,FnlDlDt,char,8;
		최초인도통지일자,FstTrsfrDt,FstTrsfrDt,char,8;
		정산가격,EcPrc,EcPrc,double,15.9;
		거래시작일자(한국),DlDt,DlDt,char,8;
		거래시작시간(한국),DlStrtTm,DlStrtTm,char,6;
		거래종료시간(한국),DlEndTm,DlEndTm,char,6;
		거래시작일자(현지),OvsStrDay,OvsStrDay,char,8;
		거래시작시간(현지),OvsStrTm,OvsStrTm,char,6;
		거래종료일자(현지),OvsEndDay,OvsEndDay,char,8;
		거래종료시간(현지),OvsEndTm,OvsEndTm,char,6;
		거래가능구분코드,DlPsblCd,DlPsblCd,char,1;
		증거금징수구분코드,MgnCltCd,MgnCltCd,char,1;
		개시증거금,OpngMgn,OpngMgn,double,15.2;
		유지증거금,MntncMgn,MntncMgn,double,15.2;
		개시증거금율,OpngMgnR,OpngMgnR,double,7.3;
		유지증거금율,MntncMgnR,MntncMgnR,double,7.3;
		유효소수점자리수,DotGb,DotGb,long,2;
		시차,TimeDiff,TimeDiff,long,5;
		현지체결일자,OvsDate,OvsDate,char,8;
		한국체결일자,KorDate,KorDate,char,8;
		현지체결시간,TrdTm,TrdTm,char,6;
		한국체결시각,RcvTm,RcvTm,char,6;
		체결가격,TrdP,TrdP,double,15.9;
		체결수량,TrdQ,TrdQ,long,10;
		누적거래량,TotQ,TotQ,long,15;
		체결거래대금,TrdAmt,TrdAmt,double,15.2;
		누적거래대금,TotAmt,TotAmt,double,15.2;
		시가,OpenP,OpenP,double,15.9;
		고가,HighP,HighP,double,15.9;
		저가,LowP,LowP,double,15.9;
		전일종가,CloseP,CloseP,double,15.9;
		전일대비,YdiffP,YdiffP,double,15.9;
		전일대비구분,YdiffSign,YdiffSign,char,1;
		체결구분,Cgubun,Cgubun,char,1;
		등락율,Diff,Diff,double,6.2;
	end
	END_DATA_MAP
END_FUNCTION_MAP

