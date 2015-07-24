public class ViewAsPDFBytetArray : ViewAsPdf
{
  public ViewAsPDFBytetArray(string viewName, object model) : base(viewName, model) { }

  public byte[] GetByte(ControllerContext context)
  {
    base.PrepareResponse(context.HttpContext.Response);
    base.ExecuteResult(context);
    return base.CallTheDriver(context);
  }
}
