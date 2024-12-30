using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace MenuAndOrderLibrary.Tests
{
    public class OrderTests
    {
        [Fact]
        public void CalculateTotal_ShouldReturnCorrectTotal()
        {
            var order = new Order(1);
            order.OrderedDishes.Add(new Dish("���", 50.5m));
            order.OrderedDishes.Add(new Dish("�����", 30.25m));

            var total = order.CalculateTotal();

            Assert.Equal(80.75m, total);
        }
        [Fact]
        public void UpdateOrderStatus_ShouldUpdateStatusCorrectly()
        {
            var order = new Order(1);
            order.UpdateOrderStatus("��������");
            order.UpdateOrderStatus("������");

            Assert.Equal("������", order.Status);
        }

        [Fact]
        
        public void UpdateOrderStatus_ShouldThrowForInvalidStatusChange()
        {
            var order = new Order(1);


            // 1. ������ ������ ������ �� "�����"
            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("�����"));

            // 2. ������ ������ ������ �� "������"
            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("������"));


            // 3. ��������� ���� ������� �� "��������"
            order.UpdateOrderStatus("��������");

            // 4. ������ ������ ������ �� "��������"
            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("��������"));

            // 5. ������ ����������� ����� �� "�����" (�����������)
            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("�����"));

            // 6. ������ ������ ������ �� ������������ (���������, "���������", ���� ���� ���� � ������)
            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("���������"));

            // 7. ���� ������� �� "������" (���������� ����������)
            order.UpdateOrderStatus("������");

            // 8. ������ ������ ������ ���� ����������
            Assert.Throws<InvalidOperationException>(() => order.UpdateOrderStatus("��������"));
        }
    }

}