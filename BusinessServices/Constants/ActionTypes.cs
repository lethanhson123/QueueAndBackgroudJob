namespace BusinessServices.Constants
{
    public enum ActionTypes
    {
        SEND_MAIL_DELIVERY,
        SYNC_ORDER,
		SYNC_ORDER_DELIVERY_NOTSYNC,
		SYNC_ORDER_DELIVERY_NOT_DISPATCH,
		SYNC_PRODUCT,
		ReminderPaymentNotification
	}
    public enum ActionStatus
    {
        NEW,
        ERROR,
        DONE
    }
    public enum ConstantCode
    {
        CALL_API_ORDER_DISPATCH_FAIL = -5,
        SOME_ORDER_SYNC_FAIL = -4,
        PUSH_TO_QUEUE_FAIL = -3,
        EXCEPTION_ERROR = -2,
        UNHANDLE_ERROR = 0,
        SUCCESSFULL = 1,
        AUTHENTICATE_FAIL = 2,
        DUPPLICATE_TRANSACTION = 3,
        UNKNOW_COMMAND = 4,
        BODY_INVALID = 5,
        NOT_ALLOWED_IP = 6,
        DB_EXCUTE_FAIL = -1,
        LOAD_DATA_FROM_SESSION_FAIL = -1000,
        LOAD_DATA_FROM_DB_FAIL = -1001,
        INSERT_DATA_TO_DB_FAIL = -1002,
        UPDATE_DATA_TO_DB_FAIL = -1003,
        PROMOTION_SCORE_NOT_ENOUGH = -1004,
        BALANCE_NOT_EXISTS = -1005,
        LOGIN_FAIL = -1006,
        REQUIRE_LOGIN = -1007,
        WRONG_DATASIGN = 2106,
        NOT_HAVE_PERMISSION_CALL_METHOD = 2016,
        CANCEL_DELETE = 2017
    }
    public class ConstantMessage
    {
        public const string CALL_API_ORDER_DISPATCH_FAIL = "CALL_API_ORDER_DISPATCH_FAIL";
        public const string SOME_ORDER_SYNC_FAIL = "SOME_ORDER_SYNC_FAIL";
        public const string PUSH_TO_QUEUE_FAIL = "PUSH_TO_QUEUE_FAIL";
        public const string EXCEPTION_ERROR = "EXCEPTION_ERROR";
        public const string UNHANDLE_ERROR = "UNHANDLE_ERROR";
        public const string SUCCESSFULL = "SUCCESSFULL";
        public const string AUTHENTICATE_FAIL = "AUTHENTICATE_FAIL";
        public const string DUPPLICATE_TRANSACTION = "DUPPLICATE_TRANSACTION";
        public const string UNKNOW_COMMAND = "UNKNOW_COMMAND";
        public const string BODY_INVALID = "BODY_INVALID";
        public const string NOT_ALLOWED_IP = "NOT_ALLOWED_IP";
        public const string DB_EXCUTE_FAIL = "DB_EXCUTE_FAIL";
        public const string LOAD_DATA_FROM_SESSION_FAIL = "LOAD_DATA_FROM_SESSION_FAIL";
        public const string LOAD_DATA_FROM_DB_FAIL = "LOAD_DATA_FROM_DB_FAIL";
        public const string INSERT_DATA_TO_DB_FAIL = "INSERT_DATA_TO_DB_FAIL";
        public const string UPDATE_DATA_TO_DB_FAIL = "UPDATE_DATA_TO_DB_FAIL";
        public const string BALANCE_NOT_EXISTS = "BALANCE_NOT_EXISTS";
        public const string LOGIN_FAIL = "LOGIN_FAIL";
        public const string REQUIRE_LOGIN = "REQUIRE_LOGIN";
        public const string WRONG_DATASIGN = "WRONG_DATASIGN";
        public const string NOT_HAVE_PERMISSION_CALL_METHOD = "NOT_HAVE_PERMISSION_CALL_METHOD";
        public const string CANCEL_DELETE = "CANCEL_DELETE";
		public const string REMINDER_PAYMENT_NOTIFICATION = "REMINDER_PAYMENT_NOTIFICATION";
		public const string ReminderPayment = "ReminderPayment";
	}

    /// <summary>
    /// Catalogue Id
    /// </summary>
    public static class CatalogueId
    {
        public const int NetSetGo = 450;
        public const int Chobani = 464;
        public const int AUSKICK = 355;
    }

}