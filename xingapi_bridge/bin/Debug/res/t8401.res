BEGIN_FUNCTION_MAP
	.Func,주식선물마스터조회(API용)(t8401),t8401,block,headtype=A;
	BEGIN_DATA_MAP
	t8401InBlock,기본입력,input;
	begin
		Dummy,dummy,dummy,char,1;
	end
	t8401OutBlock,주식종목마스터,output,occurs;
	begin
		종목명,hname,hname,char,20;
		단축코드,shcode,shcode,char,8;
		확장코드,expcode,expcode,char,12;
		기초자산코드,basecode,basecode,char,9;
	end
	END_DATA_MAP
END_FUNCTION_MAP

