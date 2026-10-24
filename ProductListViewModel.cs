using System.Collections.Generic;
using MaSV_LTW.Models;
namespace MaSV_LTW.ViewModels { public class ProductListViewModel {
 public List<Product> Products {get;set;} = new List<Product>();
 public string Search {get;set;}
 public string Sort {get;set;}
 public int Page {get;set;}
 public int TotalPages {get;set;}
 }}
