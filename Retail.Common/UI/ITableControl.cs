﻿using Retail.Device;
using Retail.Models;
using System.Collections;
using System.Collections.Generic;
namespace Retail.UI
{
    /// <summary>
    /// Таблица чека / позиций для продажи
    /// </summary>
    public interface ITableControl : IDefaultControl
    {
        /// <summary>
        /// Очистить контрол к состоянию по умолчанию
        /// </summary>
        void ClearDefault();
        
        /// <summary>
        /// Добавить товар в чек
        /// </summary>
        /// <param name="product">Товар для добавления</param>
        /// <param name="amount">Количество добавляемого товара (Может быть и отрицательное значение, ноль не обрабатывается)</param>
        void AddProduct(Product product, decimal amount=1);

        /// <summary>
        /// Удалить из чека товар
        /// </summary>
        /// <param name="product">Товар для удаления</param>
        void DelProduct(Product product);

        /// <summary>
        /// Вернуть количество выделенного в списке товара
        /// </summary>        
        decimal GetAmountOfSelectedProduct();

        /// <summary>
        /// Установить количество у выделенного в списке товара
        /// </summary>  
        void SetAmountOfSelectedProduct(decimal amount);

        /// <summary>
        /// Вернуть позиции набранные в чеке
        /// </summary>
        /// <returns></returns>
        IEnumerable<ISaleItem> GetSaleItems();


        /// <summary>
        /// Вернуть выбранный товар
        /// </summary>
        /// <returns></returns>
        Product GetSelectedProduct();
    }
}
