namespace OoapasDemo.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'OoapasDemo.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
