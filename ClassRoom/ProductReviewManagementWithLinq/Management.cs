namespace ProductReviewManagementWithLinq;

public class Management
{
    // public readonly DataTable dataTable = new DataTable();
    public void TopRecords(List<ProductReview> listProductReview)
    {
        var recordedData = (from productReviews in listProductReview
                            orderby productReviews.Rating descending
                            select productReviews).Take(3);
        foreach (var list in recordedData)
            Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
    }

    public void SelectedRecords(List<ProductReview> listProductReview)
    {
        var recordedData = from productReviews in listProductReview
                           where (productReviews.ProducID == 1 || productReviews.ProducID == 4 || productReviews.ProducID == 9)
                           && productReviews.Rating > 3
                           select productReviews;
        //Console.WriteLine(recordedData);
        foreach (var list in recordedData)
            Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
    }

    public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
    {
        var recordedData = listProductReview.GroupBy(y => y.ProducID).Select(x => new { ProductID = x.Key, Count = x.Count() });
        foreach (var list in recordedData)
            Console.WriteLine(list.ProductID + "--------" + list.Count);
    }
}
