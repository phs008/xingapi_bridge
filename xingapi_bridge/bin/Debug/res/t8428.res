BEGIN_FUNCTION_MAP
	.Func,증시주변자금추이(t8428),t8428,attr,block,headtype=A;
	BEGIN_DATA_MAP
	t8428InBlock,기본입력,input;
	begin
		from일자,fdate,fdate,char,8;
		to일자,tdate,tdate,char,8;
		구분,gubun,gubun,char,1;
		날짜,key_date,key_date,char,8;
		업종코드,upcode,upcode,char,3;
		조회건수,cnt,cnt,int,3;
	end
	t8428OutBlock,출력,output;
	begin
		날짜CTS,date,date,char,8;
		IDX,idx,idx,long,4;
	end
	t8428OutBlock1,출력1,output,occurs;
	begin
		일자,date,date,char,8;
		지수,jisu,jisu,float,7.2;
		대비구분,sign,sign,char,1;
		대비,change,change,float,6.2;
		등락율,diff,diff,float,6.2;
		거래량,volume,volume,long,12;
		고객예탁금_억원,custmoney,custmoney,long,12;
		예탁증감_억원,yecha,yecha,long,12;
		회전율,vol,vol,float,6.2;
		미수금_억원,outmoney,outmoney,long,12;
		신용잔고_억원,trjango,trjango,long,12;
		선물예수금_억원,futymoney,futymoney,long,12;
		주식형_억원,stkmoney,stkmoney,long,8;
		혼합형_억원(주식),mstkmoney,mstkmoney,long,8;
		혼합형_억원(채권),mbndmoney,mbndmoney,long,8;
		채권형_억원,bndmoney,bndmoney,long,8;
		필러(구.단기채권),bndsmoney,bndsmoney,long,8;
		MMF_억원(주식),mmfmoney,mmfmoney,long,8;
	end
	END_DATA_MAP
END_FUNCTION_MAP

