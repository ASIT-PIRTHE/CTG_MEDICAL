﻿

//$('#VoucherNumber').live('keydown',function(event){
//$("#ReceivedBy").live('keydown', function(event) {

//    if (event.which == 13 ) {   //&& !$(this).is("textarea, :button, :submit")
////        event.stopPropagation();
////        event.preventDefault();
//        alert('s');
//        event.which =9;
//        alert(event.which);
//        //$("#VoucherNumber").parent().parent().find("input")
////        $(this).parent().parent().find(":input:not(:disabled, [readonly='readonly'])").first().focus();
//        alert('s1');
//    }


//});


//document.onkeydown = tabOnEnter(this,event);







//});, :button, :submit
    

//function convertEnterToTab() {
//    alert('a');
//    alert(event.keycode);
//      if(event.keyCode == 13 ) {
//        alert('aaaa');    
//          event.keyCode = 9;
//        
//      }
//    }
//    document.onkeydown = convertEnterToTab;


function convertEnterToTab(event) {
   
    if(event.keyCode == 13 ) {        
        event.keyCode = 9;        
    }
}
//    document.onkeydown = convertEnterToTab();

    


var i = 0;
function OnCompleteAddnew(content) {
    if (content.statusText == 'OK') {
        $('.search-content').hide();
        $('.frm-content').html(content.responseText);
        $('.date-picker').datepicker({ buttonImage: '@Url.Content("~/Content/Images/calendar-blue.gif")', dateFormat: 'dd-mm-yy', buttonImageOnly: true, showOn: "button", buttonText: 'Choose' })
            .css({ 'width': '100px' });
        i=$('#grid tbody tr').length;
    } else {
        $('#message').text('An error has occoured. Please try again.').css({ 'color': 'red' });
    }
}

function tabOnEnter(field, evt) {
   
    if (evt.keyCode == 13) {
        //if (evt.preventDefault) {
        evt.preventDefault();
        //} 
        //else if (evt.stopPropagation) {
        evt.stopPropagation();
        //} else {
        evt.returnValue = false;
        //}
            
        getNextElement(field).focus();
            
        return false;
    } else {
        return true;
    }
}

function getNextElement(field) {
    var form = field.form;
    for ( var e = 0; e < form.elements.length; e++) {
        if (field == form.elements[e]) {
            break;
        }
    }
    return form.elements[++e % form.elements.length];
}



$(function () {      
         
    preventSubmitOnEnter($("#frm")); 

    $("input[type='text']").live("keyup", function(e){
        tabOnEnter(this,e);
    });  

    $('select').live("keyup", function(e){
        tabOnEnter(this,e);
    }); 
    


    $('#VoucherTypeId').live('change',function(){
        var vt = $('#VoucherTypeId option:selected').text()
        CheckControlDisable(vt);
        PopulateVoucherNumber(vt);
        $('#PaymentTypeId').change();
        //            PopulateApproverComments();

    })
        
        
        

    function PopulateVoucherNumber(vt){ 
        mode = $('#Mode').val();

        if(vt != '[Select One]' && mode != 'Edit')
            $.get(
                    "@Url.Action("GetVoucherNumber")",
                    {'voucherType': vt},
                    function(r){
                        if(r != ''){
                            $('#VoucherNumber').val(r);
                        }
                        else{
                            $("#message").show();
                            $('#message').text(data).css({ 'color':'red' });
                            $("#message").delay(3000).hide();
                        }
                    }
            );
    }


    //        Show all Approval Comments

    //        $('#PaymentTypeId').live('change',function(){
    //           PopulateApproverComments();
    //        })


    $('#btnApproveComments').live('click',function(){
        PopulateApproverComments();
    })

    function PopulateApproverComments(){ 
        id = $('#Id').val();
        $.get(
                "@Url.Action("GetApproverComments")",
                {'Id': id},
                function(r){
                    if(r != ''){
                        alert(r);
                    }
                    else{
                        $("#message").show();
                        $('#message').text(data).css({ 'color':'red' });
                        $("#message").delay(3000).hide();
                    }
                }
            );
    }














    $("input[name=ApplicableForClient]").live('change',function(){
        var af = $("input[name=ApplicableForClient]:checked").val();
            
        $('#payeeAddr').val('');
        $.get(
                "@Url.Action("GetApplicableForList")",
                {'listFor': af},
                function(r){
                    if(r != ''){
                        $('.ddl-payee, .ddl-received').html(r);

                        $('.ddl-payee').find('select').attr('id','PayeeId').attr('name','PayeeId');
                        $('.ddl-received').find('select').attr('id','ReceiveId').attr('name','ReceiveId');

                        CheckControlDisable($('#VoucherTypeId option:selected').text());
                    }
                    else{
                        $("#message").show();
                        $('#message').text(data).css({ 'color':'red' });
                        $("#message").delay(3000).hide();
                    }
                }
            );
    });


    //cxvcxv

    /*
    $("#target").keypress(function(event) {
if ( event.which == 13 ) {
 event.preventDefault();
}
*/

    //         $('#VoucherNumber').live('keydown',function(event){
    //         alert(event.which);
    //            if (event.which == 13) 
    //            {
    //            
    //                if ((event.srcElement.id.search("btn") == -1) && (event.srcElement.type != "textarea"))
    //                {
    //                    if (event.srcElement.type == "file") { 
    //                        var field = event.target ? event.target : event.srcElement;
    //                        var el = getNextElement(field);
    //                        el.focus();
    //                        return false;
    //                    }
    //                    else
    //                    {
    //                     event.which = 9; 
    //                     alert(event);
    //                     }
    //                }
    //            }     
    //        });

        
    //document.onkeydown = documentOnKeyDown;

    //xcvbxcv

    $("#PayeeId").live('change',function(){
        var id = $(this).val();
        var af = $("input[name=ApplicableForClient]:checked").val();

        if(id!='')
            $.get(
                    "@Url.Action("GetPayeeAddress")",
                    {'type': af + ',' + id},
                    function(r){
                        if(r != ''){
                            $('#payeeAddr').val(r);
                            //$('.ddl-account').find('select').attr('id','BankAccountId').attr('name','BankAccountId');
                        }
                        else{
                            $('#payeeAddr').val('');
                        }
                    }
            );
    })
        
    $('#PaymentTypeId').live('change',function(){
        $('#BankId').change();
    })
        

    $("#BankId").live('change',function(){
        var id = $(this).val();
        var paymentMode = $('#PaymentTypeId option:selected').text();
        var vt = $('#VoucherTypeId option:selected').text();

        $('#BankAccountId').attr('name', 'BankAccountId').show();
        $('#txtAccNo').attr('name','').hide();
            
        $('.cheque-no').each(function(index){
            if($(this).attr('name') == ''){
                    
                $(this).attr('name',$( $('.txt-cheque-no')[index] ).attr('name')).show();

                $( $('.txt-cheque-no')[index] ).attr('name','').hide();
            }
        })

        if(paymentMode == 'Cheque' && vt == 'RV'){
            $('#BankAccountId').attr('name','').hide();
            $('#txtAccNo').attr('name', 'BankAccountId').show();

            $('.cheque-no').each(function(index){
                $($('.txt-cheque-no')[index]).attr('name',$(this).attr('name')).show();
                $(this).attr('name','').hide();
            })
                
        }
        else{
            //populate acc no
            if(id!='')
                $.get(
                        "@Url.Action("GetAccountNumber")",
                        {'id': id},
                        function(r){
                            if(r != ''){
                                $('.ddl-account').html(r);
                                $('.ddl-account').find('select').attr('id','BankAccountId').attr('name','BankAccountId');
                                $('#BankAccountId').val($('.tmp-accno').text());
                                $('.tmp-accno').text('')
                                $('#BankAccountId').change();
                            }
                            else{
                                $("#message").show();
                                $('#message').text(data).css({ 'color':'red' });
                                $("#message").delay(3000).hide();
                            }
                        }
                );
            //populate cheque no
        }

            
    })

    $('#BankAccountId').live('change',function(){
        var id = $(this).val();
        var voucherId = $('#Id').val();
        var vt = $('#VoucherTypeId option:selected').text();
        if(id!='' && vt=='PV')
            $.get(
                    "@Url.Action("GetChequeNumber")",
                    {'id': id,'mode': $('#Mode').val(),'voucherId':voucherId},
                    function(r){
                        if(r != ''){
                            $('.cheque-no option').remove();
                            $('.cheque-no').each(function(ddli){
                                var ddl = $(this);
                                ddl.append('<option value="" >[Select One]</option>');
                                $(r).each(function(index){
                                    ddl.append('<option value="'+ r[index].Value +'" >'+ r[index].Text +'</option>');
                                })
                                ddl.val($('.tmp-cheque-no-'+ddli).text());
                                $('.tmp-cheque-no-'+ddli).text('')
                            })
                        }
                        else{
                            $('.cheque-no option').remove();
                            $('.cheque-no').append('<option value="" >[Select One]</option>');
                        }
                    }
                );
    else{
                $('.cheque-no option').remove();
        $('.cheque-no').append('<option value="" >[Select One]</option>');
    }
    })

$(".ddl-acc-head-name, .ddl-acc-head-code").live('change',function(){
    var id = $(this).val();
    $(this).parent().parent().find('select.acc-head').each(function(index){
        $(this).val(id);
    });            
    ShowAccountHeadBalance(id);
            
})

$(".ddl-acc-head-name, .ddl-acc-head-code").live('focus',function(){
    var id = $(this).val();
    $(this).parent().parent().find('select.acc-head').each(function(index){
        $(this).val(id);
    });            
    ShowAccountHeadBalance(id);
            
})


function ShowAccountHeadBalance(headId){ 
            
    if(headId != '[Select One]')
        $.get(
                "@Url.Action("GetAccountHeadBalance")",
{'headId': headId},
function(r){
    if(r != ''){
        $('#SelectedHeadCurrentBalance').val(r.CurrentBalance);
        $('#SelectedAccountHeadName').val(r.AccountHeadName);
    }
    else{
        $("#message").show();
        $('#message').text(data).css({ 'color':'red' });
        $("#message").delay(3000).hide();
    }
}
                );
}




$('.debit, .credit').live('focusout',function(){
    var total = 0.0;
    var controlType = $(this).hasClass('debit') ? 'debit' : 'credit';
            
    if(controlType == 'debit'){
        $('.debit').each(function(index){                
            total += parseFloat($(this).val());
        })
        $('#debitTotal').val(total);

        //                //Calculate Selected Head Balance Will Be---
        //                var hcurrbalance =$('#SelectedHeadCurrentBalance').val();
        //                hcurrbalance=parseFloat(hcurrbalance);
        //                $('#SelectedHeadBalanceWillBe').val(hcurrbalance + total);
    }
    else{
        $('.credit').each(function(index){                
            total += parseFloat($(this).val());
        })
        $('#creditTotal').val(total);

        //                //Calculate Selected Head Balance Will Be---
        //                var hcurrbalance =$('#SelectedHeadCurrentBalance').val();
        //                hcurrbalance=parseFloat(hcurrbalance);
        //                $('#SelectedHeadBalanceWillBe').val(hcurrbalance - total);
    }
})


$('#ApprovalPathId').live('change',function(){
    var id = $(this).val();
    if(id!=''){
        $.get(
                "@Url.Action("GetEmpList")",
                {'id':id},
                function(r){
                    if(r != ''){                                
                        $('.ddl-next-app-path').html(r);
                        $('#EmpId').attr('name','CurrentApprovalNodeId').attr('id','CurrentApprovalNodeId');
                        $('#CurrentApprovalNodeId').val($('.tmp-curr-app-node').text());
                        $('.tmp-curr-app-node').text('')
                    }
                    else{
                        //$('.search-content').hide();
                        $("#message").show();
                        $('#message').text(data).css({ 'color':'red' });
                        $("#message").delay(3000).hide();
                    }
                }
            );
    }
})
})
    
$('#btnAdd').live('click', function () {        
    $('#message').empty();
              
    var tr = $('#grid tbody tr').first().clone();
        
    var Id = $(tr).find("td:eq(0)").find("input");
    var VoucherId = $(tr).find("td:eq(1)").find("input");

    var AmountHeadId = $(tr).find("td:eq(2)").find("select");
    $(tr).find("td:eq(3)").find("select").val("");

    var debit = $(tr).find("td:eq(4)").find("input");
    var credit = $(tr).find("td:eq(5)").find("input");

    var chequeNo = $(tr).find("td:eq(6)").find("select");
    var chequeNoRV = $(tr).find("td:eq(7)").find("input");
    var project = $(tr).find("td:eq(8)").find("select");

    var remarks = $(tr).find("td:eq(9)").find("input");

        

    FilterChequeNo(chequeNo);

    //reset the value
    $(Id).val('0');
    $(VoucherId).val('0');
    $(AmountHeadId).val('');
    $(debit).val('');
    $(credit).val('');
    $(chequeNo).val('');
    $(chequeNoRV).val('');
    $(project).val('');
    $(remarks).val('');

                
        

    $('#grid').find('tbody').append('<tr class="row">' + $(tr).html() + '</tr>')
        
    RearrengeControlName();
})

$('.row a.deleteRow').live('click', function () {
    if($('#grid tbody tr').length>1)
        $(this).parent().parent().remove();
        
    var total = 0.0;
    $('.debit').each(function(index){                
        total += parseFloat($(this).val());
    })
    $('#debitTotal').val(total);
    total = 0.0;
    $('.credit').each(function(index){                
        total += parseFloat($(this).val());
    })            
    $('#creditTotal').val(total);

    RearrengeControlName();
})

$('#btnClear').live('click',function(){
    document.getElementById('frm').reset();
    $('#btnAdd').show();     
})








function ValidateForm(){
    var flag='';

    $('.fixedContent').find('input').attr('disabled',false)
    $('.fixedContent').find('select').attr('disabled',false)
    $('.fixedcontenttable').find('input').attr('disabled',false)
    $('.fixedcontenttable').find('select').attr('disabled',false)
    $('#Narration').attr('disabled',false);

    $('#BankOrCash').each(function(i){
        if($(this).val()=='Bank' && this.checked){

            if( $('#VoucherTypeId option:selected').text() != 'JV' && $('#VoucherTypeId option:selected').text() != 'AV') // Will check when not JV or AV type voucher
                $('#BankId').each(function(i){
                    if($(this).val()=='') 
                    { 
                        // alert("Please Select a Bank Name.");
                        $(this).addClass('input-validation-error');
                        flag='invalid'; 
                        return false;
                    }
                }) 
                
                  
                                        
        }
          
    })

    if(flag=='invalid')
    {
        return false;     
    }
        
        
    $('.ddl-acc-head-code').each(function(i){
        if($(this).val()=='')
            $(this).addClass('input-validation-error');
    })

    //        $('.debit').each(function(i){
    //            if($(this).val()=='0')
    //                $(this).addClass('input-validation-error');
    //        })

    //        $('.credit').each(function(i){
    //            if($(this).val()=='0')
    //                $(this).addClass('input-validation-error');
    //        })
        

    $('.cheque-no, txt-cheque-no').each(function(i){
        if($(this).val()=='')
            $(this).addClass('input-validation-error');
    })

    $('.ddl-project').each(function(i){
        if($(this).val()=='')
            $(this).addClass('input-validation-error');

        return false;
    })

    if($('#debitTotal').val()!= $('#creditTotal').val()){
        $('#debitTotal, #creditTotal').addClass('input-validation-error');
        $("#message").show();
        $('#message').text("Total Debit and Total Credit must be equal.").css({ 'color':'red' });
        //$("#message").delay(3000).hide();
        return false;
    }
    else{
        $("#message").text('');
    }

    if($('#debitTotal').val()==0 || $('#creditTotal').val()==0){
        $('#debitTotal, #creditTotal').addClass('input-validation-error');
        $('#message').show();
        $('#message').text("Total Debit and Total Credit must be greater than 0.").css({'color':'red'});
        return false;
    }
    else{
        $('#debitTotal, #creditTotal').removeAttr('input-validation-error');
        $("#message").text('');
    }
        
        
    if ($('#VoucherTypeId option:selected').text()=='PV'){
        if($('#PayeeId option:selected').val()=='' ){
            $('#PayeeId').addClass('input-validation-error');
            $('#message').show();
            $('#message').text("Payment Voucher should have Payee Information.").css({'color':'red'});
            return false;
        }
    }


    if($('#VoucherTypeId option:selected').text()=='RV'){
        if($('#ReceiveId option:selected').val()==''){
            $('#ReceiveId').addClass('input-validation-error');
            $('#message').show();
            $('#message').text("Receive Voucher should have Receive From Information.").css({'color':'red'});
            return false;
        }
    }


    var x = true;
    //  $('.credit').addClass('text-box single-line input-validation-error');
    $('#grid tbody tr').each(function(i){
           
        var d= $(this).find("td").find("input")[2].value;
        d=parseFloat(d);
        var c= $(this).find("td").find("input")[3].value;
        c=parseFloat(c);
        if( d>0 && c>0 )
        {
            // $(this).find("td").find("input")[3].addClass('text-box single-line input-validation-error');

            $("#message").show();
            $('#message').text("Both Debit and Credit is not allowed in same row.").css({ 'color':'red' });
            x=false;
            return false;
              
        }

    });


    //  Check if invoice realized voucher exceeds invoice voucher amount

    if($('#ReferenceType').val()=='Invoice')
    {
                
        if($('#ReferenceNumber').val() <= 0)
        {
            alert("For Realize voucher reference invoice voucher no is required.")
            return false;
        }

        if(parseFloat($('#InvoiceVoucherAmount').val()) <  parseFloat($('#RealizationVoucherTotal').val()) + parseFloat($('#debitTotal').val()))
        {
            //                    alert("Total Realized amount exceeds Invoice Amount.")
            //                    return false;

            if(confirm("Total Realized amount exceeds Invoice Amount. Do you want to create the voucher?"))
            {
                    
            }
            else
            {
                return false;
            }
        }
    }
    return x;

        
}

function RearrengeControlName(){
    $('#grid tbody tr').each(function(outIndex){
        $(this).find('td').each(function(innerIndex){
            if($(this).find('select').length>0)
                $(this).find('select').attr('name', $(this).find('select').attr('name').replace(/\[(.*?)\]/, '['+ outIndex + ']'));
            else if($(this).find('input').length>0)
                $(this).find('input').attr('name', $(this).find('input').attr('name').replace(/\[(.*?)\]/, '['+ outIndex + ']'));
                
        })
    })
}

function FilterChequeNo(newChequeNo){
    var existingChequeNo = new Array();
    $('.cheque-no').each(function(i){
        existingChequeNo[i] = $(this).val();
    })
        
    $(newChequeNo).find('option').each(function(i){            
        var id = $(this).attr('value');

        //            if(existingChequeNo.indexOf(id)!= -1){
        if(existingChequeNo.indexOf(id)!=-1 && id!=""){
            $(newChequeNo).find('option[value="'+ id +'"]').remove();
        }
    })
        
}


