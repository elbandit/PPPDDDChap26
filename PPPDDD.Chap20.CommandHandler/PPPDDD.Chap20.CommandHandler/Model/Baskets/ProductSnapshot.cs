﻿using PPPDDD.Chap20.CommandHandler.Common;

namespace PPPDDD.Chap20.CommandHandler.Model.Baskets
{
    public class ProductSnapshot
    {
        private readonly int _id;
        private Money _price;

        private ProductSnapshot()
        {
        }

        public ProductSnapshot(int id, Money price)
        {
            // TODO: Check for null values and invalid data
            _id = id;
            _price = price;
        }

        public Money price
        {
            get { return _price; }
        }

        public int id
        {
            get { return _id; }
        }

    }
}