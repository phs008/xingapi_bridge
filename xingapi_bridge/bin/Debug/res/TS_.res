BEGIN_FUNCTION_MAP
.Feed, OTCBBü��(TS), TS_, attr, key=6, group=1;
    BEGIN_DATA_MAP
    InBlock,�Է�,input;
    begin
		�����ڵ�,		shcode,		shcode,		char,	6;
    end
    OutBlock,���,output;
    begin
		ü��ð�,		chetime,	chetime,	char,	6;
		���ϴ�񱸺�,	sign,		sign,		char,	1;
		���ϴ��,		change,		change,		long,	8;
		�����,		    drate,		drate,		float,	6.2;
		���簡,			price,		price,		long,	8;
		�ð��ð�,		opentime,	opentime,	char,	6;
		�ð�,			open,		open,		long,	8;
		�����ð�,		hightime,	hightime,	char,	6;
		����,			high,		high,		long,	8;
		�����ð�,		lowtime,	lowtime,	char,	6;
		����,			low,		low,		long,	8;
		ü�ᱸ��,		cgubun,		cgubun,		char,	1;
		ü�ᷮ,			cvolume,	cvolume,	long,	8;
		�����ŷ���,		volume,		volume,		long,	12;
		�����ŷ����,	value,		value,		long,	12;
		�ŵ�����ü�ᷮ,	mdvolume,	mdvolume,	long,	12;
	�ŵ�����ü��Ǽ�,	mdchecnt,	mdchecnt,	long,	8;
		�ż�����ü�ᷮ,	msvolume,	msvolume,	long,	12;
	�ż�����ü��Ǽ�,	mschecnt,	mschecnt,	long,	8;
		ü�ᰭ��,		cpower,		cpower,		float,	9.2;
		������հ�,		w_avrg,		w_avrg,		long,	8;
		�����ڵ�,		shcode,		shcode,		char,	6;
    end
    END_DATA_MAP
END_FUNCTION_MAP