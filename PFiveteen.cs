using System;
using Serilog;

/*
class Program {

    static void Main(string[] args) {

        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        try {

            Log.Information("Початок обробки замовлення...");
            var order = new Order {

                OrderId = 1,
                Items = new List <OrderItem> {
                    new OrderItem { ProductId = 101, Quantity = 2 },
                    new OrderItem { ProductId = 102, Quantity = -1 }

                }
            };


            if (ValidateOrder(order)) {

                if (ProcessPayment()) {

                    ConfirmOrder(order);

                } 
                
                else {

                    Log.Error("Помилка при обробці оплати :()");

                }
            }
            
            else {

                Log.Error("Замовлення містить невалідні позиції.");

            }
        }

        catch (Exception ex) {

            Log.Error(ex, "Виникла помилка під час обробки замовлення.");

        }

        finally {

            Log.CloseAndFlush();

        }
    }

static bool ValidateOrder(Order order) {

    bool hasInvalidItems = false;
    foreach (var item in order.Items) {

        if (item.Quantity <= 0) {

            Log.Warning($"Невалідна кількість товару {item.ProductId}: {item.Quantity}. Позиція буде пропущена.");
            hasInvalidItems = true;

        }
    }

    if (!hasInvalidItems) {

        Log.Information("Замовлення успішно перевірено.");

    } 
    
    else {

        Log.Warning("Замовлення містить невалідні позиції, але обробка продовжується.");

    }

    return !hasInvalidItems;

}

    static bool ProcessPayment() {

        Random rnd = new Random();
        int result = rnd.Next(0, 2); 
        if (result == 1) {

            Log.Information("Оплата успішно оброблена.");
            return true;

        }

        else {

            Log.Error("Помилка при обробці оплати.");
            return false;

        }
    }

    static void ConfirmOrder(Order order) {

        Log.Information($"Замовлення {order.OrderId} підтверджено.");

    }
}

class Order {

    public int OrderId { get; set; }
    public List <OrderItem> Items { get; set; } = new List <OrderItem> ();

}

class OrderItem {

    public int ProductId { get; set; }
    public int Quantity { get; set; }

}
*/

/*
class Program {

    static void Main(string[] args) {

        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        bool isAuthenticated = AuthenticateUser();

        if (!isAuthenticated) {

            Log.Warning("Помилка аутентифікації. Завершення роботи програми.");
            return;

        }

        var products = SearchProducts("Ноутбук");
        if (products.Length == 0) {

            Log.Information("Товари не знайдено.");
            return;

        }

        var cart = AddToCart(products);

        Checkout(cart);

        Log.CloseAndFlush();

    }

    static bool AuthenticateUser() {

    Log.Information("Спроба аутентифікації користувача...");

    bool isAuthenticated = true;

    if (isAuthenticated) {

        Log.Information("Користувач успішно аутентифікований.");

    }

    else {

        Log.Error("Помилка аутентифікації користувача.");

    }

    return isAuthenticated;

}

    static string[] SearchProducts(string query) {

        Log.Information($"Пошук товарів за запитом: {query}");
        string[] products = { "Ноутбук A", "Ноутбук B", "Ноутбук C" };
        Log.Information($"Знайдено {products.Length} товарів.");
        return products;

    }

    static string[] AddToCart(string[] products) {

        Log.Information("Додавання товарів до кошика...");
        foreach (var product in products) {

            Log.Information($"Товар {product} додано до кошика.");

        }

        return products;
    }

    static void Checkout(string[] cart) {

        Log.Information("Спроба оформлення замовлення...");
        bool isPaymentSuccessful = new Random().Next(0, 2) == 1;

        if (isPaymentSuccessful) {

            Log.Information("Оформлення замовлення успішне. Замовлення підтверджено.");

        } 

        else {

            Log.Error("Помилка оформлення замовлення. Помилка оплати.");

        }
    }
}
*/
