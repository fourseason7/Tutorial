$PBExportHeader$w_pra03111.srw
$PBExportComments$AT&T P/O Lists with RTS Number
forward
global type w_pra03111 from w_sheet_ancestor_p
end type
type dw_1 from u_datawindow within w_pra03111
end type
type st_1 from statictext within w_pra03111
end type
type sle_sku from u_singlelineedit within w_pra03111
end type
type st_5 from statictext within w_pra03111
end type
type dp_1 from u_datepicker within w_pra03111
end type
type st_3 from statictext within w_pra03111
end type
type dp_2 from u_datepicker within w_pra03111
end type
type st_7 from statictext within w_pra03111
end type
type sle_ponumber from u_singlelineedit within w_pra03111
end type
type dw_2 from u_datawindow within w_pra03111
end type
type hpb_progress from hprogressbar within w_pra03111
end type
type st_6 from statictext within w_pra03111
end type
type ddlb_rma from u_ddlb within w_pra03111
end type
type cb_1 from commandbutton within w_pra03111
end type
type cb_import_att_po from commandbutton within w_pra03111
end type
end forward

global type w_pra03111 from w_sheet_ancestor_p
integer height = 2480
dw_1 dw_1
st_1 st_1
sle_sku sle_sku
st_5 st_5
dp_1 dp_1
st_3 st_3
dp_2 dp_2
st_7 st_7
sle_ponumber sle_ponumber
dw_2 dw_2
hpb_progress hpb_progress
st_6 st_6
ddlb_rma ddlb_rma
cb_1 cb_1
cb_import_att_po cb_import_att_po
end type
global w_pra03111 w_pra03111

type prototypes
FUNCTION INT FTPConnect (String IP_ADDRESS, String USER_ID, String PASSWORD) LIBRARY "FTP.DLL" alias for "FTPConnect;Ansi"
FUNCTION INT FTPDisconnect () LIBRARY "FTP.DLL" 
FUNCTION INT FTPgetCurrentDir (REF BLOB DATA) LIBRARY "FTP.DLL"
FUNCTION INT FTPsetCurrentDirUp () LIBRARY "FTP.DLL"
FUNCTION INT FTPsetCurrentDir (String CURR_DIR) LIBRARY "FTP.DLL" alias for "FTPsetCurrentDir;Ansi"
FUNCTION INT FTPfileList ( REF BLOB DATA ) LIBRARY "FTP.DLL"
FUNCTION INT FTPgetFile ( String REMOTE_FILE, String LOCAL_FILE, integer BINARY_OR_TEXT ) LIBRARY "FTP.DLL" alias for "FTPgetFile;Ansi" 
FUNCTION INT FTPcreateDir ( String NEW_DIR ) LIBRARY "FTP.DLL" alias for "FTPcreateDir;Ansi"
FUNCTION INT FTPdeleteFile ( String DEL_FILE ) LIBRARY "FTP.DLL" alias for "FTPdeleteFile;Ansi"
FUNCTION INT FTPdeleteDir ( String DEL_DIR ) LIBRARY "FTP.DLL" alias for "FTPdeleteDir;Ansi"
FUNCTION INT FTPrenameDir ( String CURR_DIR, String NEW_DIR ) LIBRARY "FTP.DLL" alias for "FTPrenameDir;Ansi"
FUNCTION INT FTPputFile ( String LOCAL_FILE, String REMOTE_FILE, integer BINARY_OR_TEXT ) LIBRARY "FTP.DLL" alias for "FTPputFile;Ansi" 
FUNCTION INT FTPping ( String IPaddress ) LIBRARY "FTP.DLL" alias for "FTPping;Ansi"
end prototypes

type variables
string is_uploaddate
end variables

forward prototypes
public function boolean wf_download_ftpfile (string ag_account)
public function boolean wf_ftp_download (string ag_account_no)
end prototypes

public function boolean wf_download_ftpfile (string ag_account);string ls_hostname, ls_username, ls_password, ls_port
string ls_download_folder

// application path
ClassDefinition  lcd

String ls_fullpath 
ulong lul_handle, lul_length = 512

IF handle(getapplication()) = 0 THEN
    // running from the IDE
    lcd=getapplication().classdefinition
    ls_fullpath = lcd.libraryname
ELSE
    // running from EXE
    lul_handle = handle( getapplication() )
    ls_fullpath=space(lul_length) 
    GetModuleFilename( lul_handle, ls_fullpath, lul_length )
END IF

// set initial configration
choose case ag_account
	case "MPCS"
		ls_hostname	= "broadtechinc.brickftp.com"
		ls_username = "CVE_ALLEN"
		ls_password = ""
		ls_port = "990"
		ls_fullpath = ls_fullpath + "\" + ag_account
	case else
end choose

// process to connect to FTP and download file




return true
end function

public function boolean wf_ftp_download (string ag_account_no);//string 	ls_server, ls_id, ls_password, ls_port, ls_filelist, ls_temp, ls_file
//string	ls_server_path, ls_local_path
//integer li_i, li_return, i
//blob	lb_filelist
//long	ll_find, ll_start, ll_list
//
//choose case ag_account_no
//	case "MPCS"
//		ls_server = "broadtechinc.brickftp.com"
//		ls_id = "CVE_ALLEN"
//		ls_password = "0709A113N"
//		ls_server_path = "/"
//		ls_local_path = "C:\CVE_AMES\BroadTech"
//		
//		li_i = FTPConnect( ls_server, ls_id, ls_password)
//		
//		//메시지박스에 li_i값은 0을 가져와서 FTP에 접속이 되는것같습니다.
//		If li_i = -1 then
//			messagebox("Error!", "FTP Server Connect Error!")
//			SetPointer(Arrow!)
//			return false
//		//ElseIf li_i = 0 Then 
//		End if
//		
//		yield()
//		
//		//FTP /asn/ 설정
//		li_i = FTPsetCurrentDir( ls_server_path )
//
//		//FTP ASN File List를 가져온다
//		lb_filelist = blob(space(5120))
//		li_i = FTPfileList( lb_filelist )
//		
//		ls_fileList = String(lb_fileList, EncodingANSI!)
//		
//		//ListBox에 Listing
//		ll_start = 1
//		ll_list = pos (ls_fileList, "~t", 1)
//		DO WHILE ll_list > 0
//			ls_temp = mid(ls_fileList, ll_start, ll_list - ll_start )
//			ll_find = pos( UPPER(ls_temp), ".txt", 1)
//			if ll_find > 0 then
//				lb_asn.additem (ls_temp)
//			end if
//			ls_temp = ""
//			ll_start = ll_list + 1
//			ll_list = pos (ls_fileList, "~t", ll_start)
//			yield()
//		LOOP
//
//		IF lb_asn.totalItems() = 0 THEN
//			messagebox("Warning!", "FTP Download : There are no asn files")
//			return false
//		END IF
//
//		Yield()
//		
//	   IF DirectoryExists(ls_local_path) THEN
//		li_Return = 1
//	   ELSE
//		li_return = CreateDirectory(ls_local_path)
//	   END IF
//		
//		//Local폴더로 Download
//		FOR i = 1 TO lb_asn.totalItems()
//			yield()
//			ls_file = lb_asn.Text(i)
//			//FileDownload
//			if FileExists( ls_local_path + "\" +ls_file ) then
//				FileDelete( ls_local_path + "\" + ls_file )
//			end if
//			li_i = FtpGetFile(ls_file, ls_server_path + ls_file, 0)
//			//Download성공이면 Remote 폴더에서 Delete
//			IF li_i = 0 THEN
//				li_i = FtpDeleteFile(ls_file)
//				IF li_i = 0 THEN
//				ELSE
////					st_3.Text = "1.FTP Download : "+ls_file+ " Delete Failed at Remote Folder."
////					lb_2.insertItem(st_3.Text,lb_2.TotalItems()+1)
//				END IF	
//			ELSE
////				st_3.Text = "1-4. FTP Download : " + ls_file + ' --> Download Failed.'
////				lb_2.insertItem(st_3.Text,lb_2.TotalItems()+1)
//			END IF
//			Yield()
//		NEXT
//		
//		//접속종료
//		li_i = FTPDisconnect()
//		
//		IF li_i = 0 THEN
//		ELSE
////			st_3.Text = "1-8. FTP Disconnect Error."
////			lb_2.insertItem(st_3.Text,lb_2.TotalItems()+1)
////			SetPointer(Arrow!)
////			return 0
//		END IF
//		yield()
//		
//		SetPointer(Arrow!)
//			
//		
//	case else
//		return true
//end choose
//
//
//
return true
end function

on w_pra03111.create
int iCurrent
call super::create
this.dw_1=create dw_1
this.st_1=create st_1
this.sle_sku=create sle_sku
this.st_5=create st_5
this.dp_1=create dp_1
this.st_3=create st_3
this.dp_2=create dp_2
this.st_7=create st_7
this.sle_ponumber=create sle_ponumber
this.dw_2=create dw_2
this.hpb_progress=create hpb_progress
this.st_6=create st_6
this.ddlb_rma=create ddlb_rma
this.cb_1=create cb_1
this.cb_import_att_po=create cb_import_att_po
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=this.dw_1
this.Control[iCurrent+2]=this.st_1
this.Control[iCurrent+3]=this.sle_sku
this.Control[iCurrent+4]=this.st_5
this.Control[iCurrent+5]=this.dp_1
this.Control[iCurrent+6]=this.st_3
this.Control[iCurrent+7]=this.dp_2
this.Control[iCurrent+8]=this.st_7
this.Control[iCurrent+9]=this.sle_ponumber
this.Control[iCurrent+10]=this.dw_2
this.Control[iCurrent+11]=this.hpb_progress
this.Control[iCurrent+12]=this.st_6
this.Control[iCurrent+13]=this.ddlb_rma
this.Control[iCurrent+14]=this.cb_1
this.Control[iCurrent+15]=this.cb_import_att_po
end on

on w_pra03111.destroy
call super::destroy
destroy(this.dw_1)
destroy(this.st_1)
destroy(this.sle_sku)
destroy(this.st_5)
destroy(this.dp_1)
destroy(this.st_3)
destroy(this.dp_2)
destroy(this.st_7)
destroy(this.sle_ponumber)
destroy(this.dw_2)
destroy(this.hpb_progress)
destroy(this.st_6)
destroy(this.ddlb_rma)
destroy(this.cb_1)
destroy(this.cb_import_att_po)
end on

event ue_retrieve;call super::ue_retrieve;SetPointer(HourGlass!)

datetime 	ldt_fdate, ldt_tdate
string		ls_ponumber, ls_sku

TRY
	ldt_fdate = DateTime(Date(dp_1.text),Time('00:00'))
	ldt_tdate = DateTime(Date(dp_2.text),Time('23:59'))
	
	ls_ponumber = trim(sle_ponumber.text)
	ls_sku = trim(sle_sku.text)

	dw_1.reset( )
	dw_1.retrieve( ldt_fdate, ldt_tdate, ls_ponumber, ls_sku)
	dw_1.object.datawindow.readonly = "Yes"
	dw_1.setredraw( true )
	
	
	dw_1.Event RowFocusChanged(dw_1.GetRow())
	
	dw_1.Setfocus()
CATCH (Exception e)
	MessageBox("Exception Error!", e.GetMessage())
CATCH (runtimeerror rte)
	MessageBox("Runtime Error!", rte.GetMessage())
FINALLY
	SetPointer(Arrow!)
END TRY

end event

event open;call super::open;////set initialize

//this.windowstate = Maximized!

string ls_account

dw_2.visible = false

hpb_progress.visible = false
//st_progress_status.visible = false

end event

event ue_postopen;call super::ue_postopen;wf_set_resize(TRUE)
inv_resize.of_register( gb_1, SCALERIGHT) 
inv_resize.of_register( dw_1, scalerightbottom) 
inv_resize.of_register( cb_import_att_po, FIXEDRIGHT) 
inv_resize.of_register( hpb_progress, FIXEDBOTTOM_SCALERIGHT) 


/*
FIXEDRIGHT : 윈도우의 오른쪽을 기준으로 해당 거리만큼에 항상 고정됨. 보통 버튼에 사용
FIXEDBOTTOM : 윈도우의 밑을 기준으로 해당 거리만큼 항상 고정됨.
FIXEDRIGHTBOTTOM : 윈도우의 오른쪽과 밑을 기준으로 해당거리만큼 항상 고정됨.
SCALE : 비율대로 조정됨
SCALERIGHT : 윈도우의 오른쪽을 기준으로 너비가 윈도우 너비에 따라 변경됨 
SCALEBOTTOM : 윈도우의 밑쪽을 기준으로 높이가 윈도우 높이에 따라 변경됨.
SCALERIGHTBOTTOM :윈도우의 오른쪽과 밑쪽을 기준으로 너비와 높이가 윈도우의 너비와 높이에 따라 변경됨.
FIXEDRIGHT_SCALEBOTTOM :오른쪽은 고정이고, 밑쪽으로는 변경됨
FIXEDBOTTOM_SCALERIGHT :밑쪽을 기준으로 고정이고, 너비는 변경됨
*/

end event

type p_point from w_sheet_ancestor_p`p_point within w_pra03111
end type

type gb_1 from w_sheet_ancestor_p`gb_1 within w_pra03111
integer height = 260
integer taborder = 0
end type

type dw_1 from u_datawindow within w_pra03111
integer x = 46
integer y = 292
integer width = 4553
integer height = 2088
integer taborder = 0
boolean bringtotop = true
string dataobject = "d_pra03111"
end type

event doubleclicked;call super::doubleclicked;//if row > 0 then
//	if this.GetItemString(row, 'imei_no') > '' then
//		gs_imei_no = this.GetItemString(row, 'imei_no')
//		Open_Sheet('W_PRA02990', 8)
//	end if
//end if


end event

event sqlpreview;call super::sqlpreview;string ls_text

ls_text = sqlsyntax
end event

type st_1 from statictext within w_pra03111
integer x = 128
integer y = 172
integer width = 334
integer height = 60
boolean bringtotop = true
integer textsize = -8
integer weight = 700
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "SKU.:"
alignment alignment = right!
boolean focusrectangle = false
end type

type sle_sku from u_singlelineedit within w_pra03111
integer x = 466
integer y = 156
integer width = 640
integer height = 84
integer taborder = 30
boolean bringtotop = true
end type

event ue_keydown;if key = keyenter! then
	send(handle(this),256,9,long(0,0))
	Return 1	// Prevent Enter Key
end if
end event

type st_5 from statictext within w_pra03111
integer x = 133
integer y = 72
integer width = 315
integer height = 60
boolean bringtotop = true
integer textsize = -8
integer weight = 700
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "PO Date.:"
alignment alignment = right!
boolean focusrectangle = false
end type

type dp_1 from u_datepicker within w_pra03111
integer x = 466
integer y = 56
integer width = 384
integer height = 88
integer taborder = 10
boolean bringtotop = true
datetime value = DateTime(Date("2018-05-23"), Time("09:03:15.000000"))
integer calendarfontweight = 400
end type

event constructor;call super::constructor;//this.SetToday(Date(string(RelativeDate(today(), -90), 'mm/01/yyyy')))

datetime ldt_podate
SELECT min(a.POCreationDate) as POCreateionDate
  INTO :ldt_podate
  FROM PMS_ASN_FILE_ATT_POLIsts a
 where a.Remaining > 0;
 
if isnull(ldt_podate) then
	ldt_podate = datetime(date(RelativeDate(today(), -365)), time("00:00"))
end if

//this.SetValue(Date(string(RelativeDate(today(), -365), 'mm/01/yyyy')), Time('00:00:00'))
this.SetValue(Date(string(ldt_podate, 'mm/01/yyyy')), Time('00:00:00'))
end event

type st_3 from statictext within w_pra03111
integer x = 855
integer y = 60
integer width = 69
integer height = 84
boolean bringtotop = true
integer textsize = -12
integer weight = 700
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "-"
alignment alignment = center!
boolean focusrectangle = false
end type

type dp_2 from u_datepicker within w_pra03111
integer x = 928
integer y = 56
integer width = 384
integer height = 88
integer taborder = 20
boolean bringtotop = true
datetime value = DateTime(Date("2018-05-23"), Time("09:03:15.000000"))
integer calendarfontweight = 400
end type

type st_7 from statictext within w_pra03111
integer x = 1568
integer y = 68
integer width = 448
integer height = 60
boolean bringtotop = true
integer textsize = -8
integer weight = 700
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "PO# or RTS#.:"
alignment alignment = right!
boolean focusrectangle = false
end type

type sle_ponumber from u_singlelineedit within w_pra03111
integer x = 2021
integer y = 52
integer width = 846
integer height = 84
integer taborder = 50
boolean bringtotop = true
end type

event ue_keydown;if key = keyenter! then
	send(handle(this),256,9,long(0,0))
	Return 1	// Prevent Enter Key
end if
end event

type dw_2 from u_datawindow within w_pra03111
integer x = 91
integer y = 852
integer width = 4475
integer height = 1328
integer taborder = 11
boolean bringtotop = true
boolean titlebar = true
string title = "PO Upload"
string dataobject = "d_pra03111_imp"
end type

event updatestart;call super::updatestart;//long ll_rowcnt, ll_row = 0
//
//ll_rowcnt = this.RowCount()
//
//setpointer(hourglass!)
//
//do while ll_row <= ll_rowcnt
//	yield()
//	hpb_progress.position = ll_row
//	yield()
//	st_progress_status.text = "Progress Status:" + string(ll_row) + "/" + string(ll_rowcnt) + "(" +string(round(ll_row / ll_rowcnt * 100, 2)) + "%)"
//
//	ll_row = this.GetNextModified(ll_row, Primary!)
//	if ll_row > 0 then
//		if this.GetItemStatus(ll_row, 0, Primary!) = NewModified! or &
//			this.GetItemStatus(ll_row, 0, Primary!) = DataModified! then
//			
//			integer li_pos
//			this.Object.CreateUser[ll_row] = gs_emp_id
//			this.Object.CreateHostName[ll_row] = gs_com_name
//			this.object.CreateDate[ll_row] = f_system_date()
//		end if
//	else
//		ll_row = ll_rowcnt + 1
//	end if	
//loop
//
//setpointer(Arrow!)
end event

type hpb_progress from hprogressbar within w_pra03111
integer x = 46
integer y = 2292
integer width = 4530
integer height = 80
boolean bringtotop = true
unsignedinteger maxposition = 100
integer setstep = 1
boolean smoothscroll = true
end type

type st_6 from statictext within w_pra03111
boolean visible = false
integer x = 2615
integer y = 72
integer width = 334
integer height = 52
boolean bringtotop = true
integer textsize = -8
integer weight = 700
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
long textcolor = 33554432
long backcolor = 67108864
string text = "RMA Type.:"
alignment alignment = right!
boolean focusrectangle = false
end type

type ddlb_rma from u_ddlb within w_pra03111
boolean visible = false
integer x = 2962
integer y = 52
integer width = 498
integer taborder = 11
boolean bringtotop = true
end type

type cb_1 from commandbutton within w_pra03111
boolean visible = false
integer x = 3090
integer y = 64
integer width = 407
integer height = 92
integer taborder = 30
boolean bringtotop = true
integer textsize = -8
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
string text = "BBY RMA Create"
end type

event clicked;//RMA Create
String	ls_carrier = 'BBY', ls_modelCd, ls_sku, ls_asnNo, ls_rmaType = 'G', ls_rmaNo, ls_sqlErrCode, ls_sqlErrText
Long	ll_asnQty

DECLARE cur_rma CURSOR FOR
select	(select top 1 model_code from pms_model_by_account where account = :ls_carrier and sku = x.sku order by  account_model) as asn_model_no,
		x.sku as asn_sku_no, count(*) as asn_quantity, 
		asn_no as asn_ref_no
from	pms_asn_file_bby x
where	not exists (select * from pms_asn_file where asn_ref_no = x.asn_no and asn_sku_no = x.sku)
group by x.asn_no, x.sku;
 
OPEN cur_rma;

FETCH cur_rma INTO :ls_modelcd, :ls_sku, :ll_asnQty, :ls_asnNo;

DO WHILE SQLCA.SQLCODE = 0
	
	SELECT	dbo.fn_GetNewRMANo(x.use_cd1, :ls_rmaType, getdate())
	INTO	:ls_rmaNo
	FROM	icb0020 x
	WHERE	class_cd = 'Z'
	AND		etc_cd = '004'
	AND		etc_scd = :ls_carrier;
	
	IF ls_rmaNo = '' OR isNull(ls_rmaNo) OR LEN(ls_rmaNo) < 12 THEN
		rollback using sqlca;
		messagebox("DB Error", "Error occurred while Creating ASN_ORDER_NO!" + ' '+ ls_rmaNo)
		dw_2.reset()
		return	
	END IF
	
	INSERT INTO pms_asn_file (asn_order_no, asn_date, division, storage, asn_account_no, asn_model_no,
							  asn_sku_no, asn_quantity, asn_rcv_qty, asn_option, asn_ref_no)
	VALUES (:ls_rmaNo, getdate(), 'CWS','AL',:ls_carrier, :ls_modelCd, 
			:ls_sku, :ll_asnQty, :ll_asnQty, :ls_rmaType, :ls_asnNo);
			
	
	 if sqlca.sqlcode <> 0 then
		ls_sqlerrcode = string(sqlca.sqldbcode)
		ls_sqlerrtext = sqlca.sqlerrtext
		rollback using sqlca;
		messagebox("DB Error", "Error occurred while inserting PMS_ASN_FILE!" + &
		"~r~nError Code : " + ls_sqlerrcode + & 
		"~r~nError Text : " + ls_sqlerrtext)
		dw_2.reset()
		return
	end if						
	
	
	FETCH cur_rma INTO :ls_modelcd, :ls_sku, :ll_asnQty, :ls_asnNo;
LOOP 
 
CLOSE cur_rma; 
end event

type cb_import_att_po from commandbutton within w_pra03111
integer x = 3502
integer y = 48
integer width = 539
integer height = 92
integer taborder = 21
boolean bringtotop = true
integer textsize = -8
integer weight = 400
fontcharset fontcharset = ansi!
fontpitch fontpitch = variable!
fontfamily fontfamily = swiss!
string facename = "Tahoma"
string text = "Import AT&&T~'s PO"
boolean flatstyle = true
end type

event clicked;string ls_doc_name, ls_file_name
integer li_rtn, li_chk_col
long ll_row, ll_rowcnt

string ls_extension, ls_filter

string ls_sqlerrcode, ls_sqlerrtext

ls_extension = "AT&T PO File"
ls_filter = "Excel Workbook (*.xlsx), *.xlsx,Excel 97-2003 (*.xls), *.xls,Text(Tab delimited) (*.txt), *.txt,All Files (*.*), *.*"
dw_2.dataobject = "d_pra03111_imp"
li_chk_col = 1


//ChangeDirectory(gs_pgmpath)
li_rtn = GetFileOpenName('Select File', ls_doc_name, ls_file_name, ls_extension, ls_filter, '%USERPROFILE%\DESKTOP', 18)

if li_rtn = 1 then
elseif li_rtn = -1 then
	MessageBox('File Error', 'File Not Found.')
	Return
elseif li_rtn = 0 then
	MessageBox('File Error', 'User clicks the Cancel button or Windows cancels the display')
	Return
else
	MessageBox('File Error', 'File Error')
	Return
end if

SetPointer(HourGlass!)

dw_2.SetTransObject(sqlca)
dw_2.Reset()

string ls_text, ls_temp, ls_today
integer li_file_num

choose case upper(right(trim(ls_doc_name), 4))
	case "XLSX", ".XLS"
		if f_sys_excel_import(ls_doc_name, dw_2, 2, li_chk_col ) <> 1 then
			return
			setpointer(Arrow!)
		else
			ll_rowcnt = dw_2.rowcount( )
		end if
	case ".TXT"
		ll_rowcnt = dw_2.importfile( Text!, ls_doc_name, 2)
	case else
		ll_rowcnt = dw_2.importfile( Text!, ls_doc_name, 2)
end choose

if ll_rowcnt = 0 then
	setpointer(Arrow!)
	return
end if

setpointer(HourGlass!)

hpb_progress.visible = true
//st_progress_status.visible = true
hpb_progress.maxposition = dw_2.rowcount( )
hpb_progress.minposition = 0

//if dw_2.update( ) = 1 then
//	commit using sqlca;
//	MessageBox('Success', 'Success.  Rows:'+string(dw_2.rowcount()))
//else
//	ls_sqlerrcode = string(sqlca.sqldbcode)
//	ls_sqlerrtext = sqlca.sqlerrtext
//	rollback using sqlca;
//	MessageBox('Failed', 'Can not import ASN File' + &
//	"~r~n~r~nError Code : " + ls_sqlerrcode + & 
//	"~r~n~r~nError Text : " + ls_sqlerrtext)
//end if

string 		ls_PONumber
string 		ls_RTSNumber
string 		ls_Supplier
date 		ld_POCreationDate
string 		ls_SKUCode
string 		ls_SKUDescription
string 		ls_SHPType
string 		ls_Program
integer     li_Ordered
integer     li_Received
integer     li_Cancelled
integer     li_Remaining
string      ls_Model
integer     li_Againg
datetime    ldt_CreateDate
string      ls_CreateUser
string      ls_CreateHostName
datetime    ldt_ModifiedDate
string      ls_ModifiedUser
string      ls_ModifiedHostName

integer		li_cnt

if dw_2.rowcount( ) > 0 then
	for ll_row = 1 to dw_2.rowcount( ) 
		
		ls_PONumber 		= dw_2.getitemstring( ll_row, "PONumber" )				
		ls_RTSNumber 		= dw_2.getitemstring( ll_row, "RTSNumber" )
		ls_Supplier			= dw_2.getitemstring( ll_row, "Supplier" )
		ld_POCreationDate	= dw_2.getitemdate( ll_row, "pocreationdate" )
		ls_SKUCode			= dw_2.getitemstring( ll_row, "SKUCode" )
		ls_SKUDescription	= dw_2.getitemstring( ll_row, "SKUDescription" )
		ls_SHPType			= dw_2.getitemstring( ll_row, "SHPType" )
		ls_Program			= dw_2.getitemstring( ll_row, "Program" )
		li_Ordered			= dw_2.getitemnumber( ll_row, "Ordered" )
		li_Received			= dw_2.getitemnumber( ll_row, "Received" )
		li_Cancelled		= dw_2.getitemnumber( ll_row, "Cancelled" )
		li_Remaining		= dw_2.getitemnumber( ll_row, "Remaining" )
		ls_Model			= dw_2.getitemstring( ll_row, "Model" )
		li_Againg			= dw_2.getitemnumber( ll_row, "Againg" )
		ls_CreateUser 		= gs_emp_id
		ls_ModifiedUser		= gs_emp_id		
		

		select count(*)
		  into :li_cnt
		  from PMS_ASN_FILE_ATT_POLIsts
		 where PONumber = :ls_PONumber;
		 
		if li_cnt = 0 then
			insert into PMS_ASN_FILE_ATT_POLIsts
			select :ls_PONumber, :ls_RTSNumber, :ls_Supplier, :ld_POCreationDate, :ls_SKUCode, :ls_SKUDescription, :ls_SHPType, :ls_Program, :li_Ordered
			      , :li_Received, :li_Cancelled, :li_Remaining, :ls_Model, :li_Againg
				  , getdate(), :ls_CreateUser, host_name(), getdate(), :ls_ModifiedUser, host_name();
		else
			update PMS_ASN_FILE_ATT_POLIsts
			   set RTSNumber        = :ls_RTSNumber
				 , Supplier         = :ls_Supplier
				 , POCreationDate   = :ld_POCreationDate
				 , SKUCode          = :ls_SKUCode
				 , SKUDescription   = :ls_SKUDescription
				 , SHPType          = :ls_SHPType
				 , Program          = :ls_Program
				 , Ordered          = :li_Ordered
				 , Received         = :li_Received
				 , Cancelled        = :li_Cancelled
				 , Remaining        = :li_Remaining
				 , Model            = :ls_Model
				 , Againg           = :li_Againg
				 , ModifiedDate     = getdate()
				 , ModifiedUser     = :ls_ModifiedUser
				 , ModifiedHostName = host_name()
			 where PONumber = :ls_PONumber;
		end if
		
		if sqlca.sqlcode <> 0 then
			ls_sqlerrcode = string(sqlca.sqldbcode)
			ls_sqlerrtext = sqlca.sqlerrtext
			
			messagebox("Warning!", "Importing Error!" + &
			"~r~nSQL Error Code: " + ls_sqlerrcode + &
			"~r~nSQL Error Text: " + ls_sqlerrtext, StopSign!)
			setpointer(Arrow!)
			return 
		end if		 		
		
		hpb_progress.position = ll_row
		yield()
		
	next 
end if

hpb_progress.maxposition = 0
hpb_progress.minposition = 0
hpb_progress.visible = false
//st_progress_status.visible = false

messagebox("Import!", "It has been completed!")

setpointer(Arrow!)


end event

