
CREATE TABLE products (
    product_id SERIAL PRIMARY KEY,
    name TEXT NOT NULL,
    category TEXT,
    brand TEXT,
    type TEXT,                           -- e.g., 'Material', 'Tool', 'Accessory'
    unit TEXT,                           -- e.g., 'kg', 'L', 'pcs'
    quantity_in_stock INTEGER DEFAULT 0,
    min_stock_alert INTEGER DEFAULT 0,
    purchase_price NUMERIC(10,2),
    selling_price NUMERIC(10,2),
    discount NUMERIC(5,2) DEFAULT 0,     -- discount percentage (e.g. 10.00 = 10%)
    barcode TEXT,
    date_added DATE DEFAULT CURRENT_DATE,
    last_updated DATE DEFAULT CURRENT_DATE
);

CREATE TABLE sales (
    sale_id SERIAL PRIMARY KEY,
    customer_name TEXT,
    total_amount NUMERIC(10,2),
    labor_fee NUMERIC(10,2) DEFAULT 0,
    discount NUMERIC(5,2) DEFAULT 0,
    payment_method TEXT,                 -- e.g., 'cash', 'card', 'bank transfer'
    sale_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE sale_items (
    sale_item_id SERIAL PRIMARY KEY,
    sale_id INTEGER REFERENCES sales(sale_id) ON DELETE CASCADE,
    product_id INTEGER REFERENCES products(product_id),
    quantity INTEGER NOT NULL,
    price_per_unit NUMERIC(10,2),
    discount NUMERIC(5,2) DEFAULT 0,     -- optional per-item discount
    total_value NUMERIC(10,2)
);

CREATE TABLE owner_usage (
    usage_id SERIAL PRIMARY KEY,
    project_name TEXT NOT NULL,                       
    total_amount NUMERIC(10,2),
    labor_fee NUMERIC(10,2) DEFAULT 0,
    discount NUMERIC(5,2) DEFAULT 0,
    payment_method TEXT,
    is_paid BOOLEAN DEFAULT TRUE,
    invoice_number TEXT,
    note TEXT,
    usage_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE owner_usage_sales (
    usage_sale_id SERIAL PRIMARY KEY,
    usage_id INTEGER REFERENCES owner_usage(usage_id) ON DELETE CASCADE,
    product_id INTEGER REFERENCES products(product_id),
    quantity INTEGER NOT NULL,
    price_per_unit NUMERIC(10,2),
    discount NUMERIC(5,2) DEFAULT 0,
    total_value NUMERIC(10,2)
);

CREATE TABLE labor_fee_history (
    fee_id SERIAL PRIMARY KEY,
    description TEXT,
    amount NUMERIC(10,2) NOT NULL,
    effective_from TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE users (
    user_id SERIAL PRIMARY KEY,
    username TEXT UNIQUE NOT NULL,
    password_hash TEXT NOT NULL,
    role TEXT CHECK (role IN ('Admin', 'Cashier')) DEFAULT 'Cashier',
    date_created TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE license_info (
    license_id SERIAL PRIMARY KEY,
    hardware_id TEXT UNIQUE NOT NULL,    
    license_key TEXT NOT NULL,
    is_active BOOLEAN DEFAULT TRUE,
    date_activated TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE transactions_log (
    log_id SERIAL PRIMARY KEY,
    action_type TEXT,                    
    reference_id INTEGER,                
    user_id INTEGER REFERENCES users(user_id),
    details TEXT,
    action_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE pay_later_sales (
    pay_later_id SERIAL PRIMARY KEY,
    customer_name TEXT NOT NULL,
    total_amount NUMERIC(10,2),
    labor_fee NUMERIC(10,2) DEFAULT 0,
    discount NUMERIC(5,2) DEFAULT 0,
    payment_method TEXT DEFAULT 'Pay Later',
    sale_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    due_date DATE,
    is_paid BOOLEAN DEFAULT FALSE
);

CREATE TABLE pay_later_items (
    pay_later_item_id SERIAL PRIMARY KEY,
    pay_later_id INTEGER REFERENCES pay_later_sales(pay_later_id) ON DELETE CASCADE,
    product_id INTEGER REFERENCES products(product_id),
    quantity INTEGER NOT NULL,
    price_per_unit NUMERIC(10,2),
    discount NUMERIC(5,2) DEFAULT 0,
    total_value NUMERIC(10,2)
);













