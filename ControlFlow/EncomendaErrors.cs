namespace sgd_cms.ControlFlow.Encomendas;

// MissingRequiredField: When a required field(e.g., order date, products) is not provided during order creation.
// InvalidFormat: When the format of a field is not valid(e.g., invalid order ID format).
// InvalidQuantity: When the provided quantity for a product in the order is not valid(e.g., negative or zero).
// InvalidProduct: When a product in the order doesn't exist or is not valid.
// InvalidCustomer: When a customer associated with the order is not valid.
// RecordNotFound: When trying to access or manipulate a non-existent order record.
enum EncomendaErrors
{
  MissingRequiredField,
  InvalidFormat,
  InvalidQuantity,
  InvalidProduct,
  InvalidCustomer,
  RecordNotFound,
}