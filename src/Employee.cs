using System;
namespace src
{
    public class Employee
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        /// <value></value>
        public string Id { get; set; }
        /// <summary>
        /// 職稱
        /// </summary>
        /// <value></value>
        public string Title { get; set; }
        /// <summary>
        /// 員工姓名
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// 到職日期
        /// </summary>
        /// <value></value>
        public string OnBoard { get; set; }
        /// <summary>
        /// 員工薪資
        /// </summary>
        /// <value></value>
        public double Salary { get; set; }
    }
}