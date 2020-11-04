BEGIN_FUNCTION_MAP
	.Func,ETF구성종목조회(t1904),t1904,attr,block,headtype=A;
	BEGIN_DATA_MAP
	t1904InBlock,기본입력,input;
	begin
		ETF단축코드,shcode,shcode,char,6;
		PDF적용일자,date,date,char,8;
		정렬기준(1:평가금액2:증권수),sgb,sgb,char,1;
	end
	t1904OutBlock,출력,output;
	begin
		당일구분,chk_tday,chk_tday,char,1;
		PDF적용일자,date,date,char,8;
		ETF현재가,price,price,long,8;
		ETF전일대비구분,sign,sign,char,1;
		ETF전일대비,change,change,long,8;
		ETF등락율,diff,diff,float,6.2;
		ETF누적거래량,volume,volume,long,12;
		NAV,nav,nav,float,8.2;
		NAV전일대비구분,navsign,navsign,char,1;
		NAV전일대비,navchange,navchange,float,8.2;
		NAV등락율,navdiff,navdiff,float,6.2;
		전일NAV,jnilnav,jnilnav,float,8.2;
		전일NAV전일대비구분,jnilnavsign,jnilnavsign,char,1;
		전일NAV전일대비,jnilnavchange,jnilnavchange,float,8.2;
		전일NAV등락율,jnilnavdiff,jnilnavdiff,float,6.2;
		업종명,upname,upname,char,20;
		업종코드,upcode,upcode,char,3;
		업종현재가,upprice,upprice,float,7.2;
		업종전일비구분,upsign,upsign,char,1;
		업종전일대비,upchange,upchange,float,6.2;
		업종등락율,updiff,updiff,float,6.2;
		선물최근월물명,futname,futname,char,20;
		선물최근월물코드,futcode,futcode,char,8;
		선물현재가,futprice,futprice,float,6.2;
		선물전일비구분,futsign,futsign,char,1;
		선물전일대비,futchange,futchange,float,6.2;
		선물등락율,futdiff,futdiff,float,6.2;
		참고지수명,upname2,upname2,char,20;
		참고지수코드,upcode2,upcode2,char,3;
		참고지수현재가,upprice2,upprice2,float,7.2;
		순자산총액(단위:억),etftotcap,etftotcap,long,12;
		구성종목수,etfnum,etfnum,long,4;
		CU주식수,etfcunum,etfcunum,long,12;
		현금,cash,cash,long,12;
		운용사명,opcom_nmk,opcom_nmk,char,20;
		전종목평가금액합,tot_pval,tot_pval,long,12;
		전종목구성시가총액합,tot_sigatval,tot_sigatval,long,12;
	end
	t1904OutBlock1,출력1,output,occurs;
	begin
		단축코드,shcode,shcode,char,12;
		한글명,hname,hname,char,20;
		현재가,price,price,long,8;
		전일대비구분,sign,sign,char,1;
		전일대비,change,change,long,8;
		등락율,diff,diff,float,6.2;
		누적거래량,volume,volume,long,12;
		거래대금(백만),value,value,long,12;
		단위증권수(계약수/원화현금/USD현금/창고증권),icux,icux,long,12;
		액면금액/설정현금액,parprice,parprice,long,12;
		평가금액,pvalue,pvalue,long,12;
		구성시가총액,sigatvalue,sigatvalue,long,12;
		PDF적용일자,profitdate,profitdate,char,8;
		비중(평가금액),weight,weight,float,6.2;
		ETF종목과등락차,diff2,diff2,float,6.2;
	end
	END_DATA_MAP
END_FUNCTION_MAP

