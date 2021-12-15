class Car {
    // Properties
    // Properties can have modificators like public, private, protected. In our case props are private
   private _brand: string;
   private _model: string;
   private _doors: number;
   private _color: string;
   private _power: number;

    // Constructor
constructor(brand: string, model: string, doors = 4, color: string, power: number) {
    this._brand = brand;
    this._model = model;
    if ((doors % 2) === 0) {
        this._doors = doors;
    } else {
        throw new Error('Doors must be an even number');
    }
    this._color = color;
    this._power = power;

}

    // Accessors
    get brand() {
        return this._brand;
    }
    set brand(brand) {
        this._brand = brand;
    }

    get model() {
        return this._model;
    }
    set model(model) {
        this._model = model;
    }

    get doors() {
        return this._doors;
    }
    set doors(doors) {
        if ((doors % 2) === 0) {
            this._doors = doors;
        } else {
            throw new Error('Doors must be an even number');
        }
    }

    get color() {
        return 'The color of the car is ' + this._color;
    }
    set color(color) {
        this._color = color;
    }

    get power() {
        return this._power;
    }
    set power(power) {
        this._power = power;
    }

    // Methods
accelerate(speed: number): string {
    return `${this.worker()} is accelerating to ${speed} MPH.`
}

brake(): string {
    return `${this.worker()} is braking with the standard braking system.`
}

turn(direction: 'left' | 'right'): string {
    return `${this.worker()} is turning ${direction}`;
}

worker(): string {
    return this._brand;
}

}

let car = new Car('Cadillac', 'Escalade', 4, 'Silver', 420);

// Class extending

class HybridCar extends Car {
    // Properties
    private _electricPower: number;

    // Constructor
    constructor(brand: string, model: string, doors = 4, color: string, power: number, electricPower: number){
        super(brand, model, doors, color, power);
        this._electricPower = electricPower;
    }

    // Accessors
    get electricPower() {
        return this._electricPower;
    }
    set electricPower(electricPower){
        this._electricPower = electricPower;
    }

    // Methods
    charge() {
        console.log(this.worker() + 'is charging now')
    }

    // Overrides the brake method of the Car class
    brake(): string {
    return `${this.worker()}  is braking with the regenerative braking system.`
}
}

let car2 = new HybridCar('Toyota', 'Highlander', 4, 'Black', 220, 130);