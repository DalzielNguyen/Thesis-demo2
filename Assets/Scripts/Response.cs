using System;

[Serializable]
public class ResponseData
{
    public string url;
}

[Serializable]
public class Response
{
    public ResponseData data;
    public int error_code;
    public string error_message;
}

