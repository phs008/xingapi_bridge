BEGIN_FUNCTION_MAP
	.Func,해외지수조회(API용)(t3521),t3521,attr,block,headtype=A;
	BEGIN_DATA_MAP
	t3521InBlock,기본입력,input;
	begin
		종목종류,kind,kind,char,1;
		SYMBOL,symbol,symbol,char,16;
	end
	t3521OutBlock,출력,output;
	begin
		심벌,symbol,symbol,char,16;
		지수명,hname,hname,char,20;
		지수,close,close,float,12.2;
		대비구분,sign,sign,char,1;
		대비,change,change,float,6.2;
		등락율,diff,diff,float,6.2;
		일자,date,date,char,8;
	end
	END_DATA_MAP
END_FUNCTION_MAP

t3521