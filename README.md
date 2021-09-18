# Edwin and Sophia

Edwin and Sophia are an algorithmic trading platform, whose core is a trading engine, limit orderbook, backtesting engine, and communication protocol implemented in C# and built on .netstandard2.1. Edwin is an order management system that takes orders, validates them against certain parameters, calculates risk and transaction costs, then sends the orders to market. Sophia is a market data management system and simulation environment.

## Network Layer

1. Receives market data from exchanges
2. Log data packet recieved to text file asynchronously
3. Send market data update to Sophia using UDP connection and order acknowledgement/fill to Edwin using gRPC connection
4. Recieve orders from Edwin and send to exchanges

## Sophia

1. Recieve messages from message bus
2. Sort bid and ask orders and store in orderbook object
3. Log orderbook updates to a text file asynchronously
4. Persist orderbook and orderbook updates to instance of InfluxDB asynchronously
5. Match orders according to exchanges orderbook
6. Persist orderbook, orderbook updates, and matched orders to Redis cache
7. Send price updates from matched trades to any listening clients

## Client

1. Create new strategy objects
2. Persist strategy objects to instance of InfluxDB asynchronously
3. Log the creation of a new strategy to a text file asynchronously
4. Recieve price updates from Sophia
5. Calculate Alpha, Risk, and Transaction model against the data
6. Persist Alpha, Risk, and Transaction model to Redis cache
7. Use Calculations to generate buy/sell signals
8. Use signals to create orders

## Edwin

1. Recieve orders from Client
2. Persist Client portfolio information to instance of InfluxDB asynchronously
3. Validate orders
4. Execute orders
5. Log order creation, execution, modification, cancelation, and rejection to a text file asynchronously
6. update orderbook with order acknowledgement and order fill

---

## Currently Supported Features

The following features are currently supported.

### Order Types

1. New Order
2. Modify Order
3. Cancel Order

### Order Responses

1. New Order Acknowledgement
2. Modify Order Acknowledgement
3. Cancel Order Acknowledgement
4. Fill

### Matching Algorithms

1. First-In-First-Out (FIFO)
2. Last-In-First-Out (LIFO)
3. Pro-Rata

### Market Data

1. Trade Summary
2. Market-By-Order Incremental Orderbook Update

---

## Planned Features

The following features are on the roadmap.

### Communication

Private gRPC stream-based communication for order entry between trading clients and the algorithmic trading platform.

### Market Data

1. Session Statistics
2. Daily Statistics

### Health Monitor

1. Reporting
2. Sensing

### Simulation Environment

1. Machine Learning
2. Portfolio Optimization

---

## Building Edwin

The following steps will allow you to build and run Edwin.

1. Download [Visual Studio 2019](https://visualstudio.microsoft.com/vs/).
2. Download this repository.
3. Open `TradingEngine.sln` under `src/TradingEngine`
4. Hit F5 to build and run the solution.

---

## EDWIN Architecture

The following is a diagram representing the architecture of EDWIN and SOPHIA.

![Edwin (3)](https://user-images.githubusercontent.com/54039249/133898304-befabd8b-9079-4fbb-af42-69d4a01ea80f.png)

**Note:** Currently, EDWIN is being worked on. Work on SOPHIA has not started yet
