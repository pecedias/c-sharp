﻿using System;
using System.Collections.Generic;
using System.Text;
using Course2.Entities.Enums;

namespace Course2.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double sum = 0;
            foreach (OrderItem items in Items) {
                sum += items.SubTotal();
            }
            return sum;
        }
    }
}
