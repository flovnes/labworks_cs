use std::io;

fn main() {
    let (room, roll) = input_values();

    println!("{}", solution(room, roll));
}

struct Room {
    length: f32,
    width: f32,
    height: f32
}

impl Room {
    fn full_area(&self) -> f32 {
        0.85*(2.*(self.height*self.width + self.length*self.height) + self.length*self.width)
    }
}

struct Roll {
    length: f32,
    width: f32
}

impl Roll {
    fn area(&self) -> f32 {
        self.length*self.width
    }
}

fn input_values() -> (Room, Roll) {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    let mut values: Vec<f32> = input_line
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    input_line.clear();
    let _ = io::stdin().read_line(&mut input_line);
    values.append(&mut input_line
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect());

    let room = Room {length: values[0], width: values[1], height: values[2]};
    let roll = Roll {length: values[3], width: values[4]};
    ((room),(roll))
}

fn solution(room: Room, roll: Roll) -> f32 {  
    (1.1 * room.full_area() / (roll.area() / 10_f32.powi(6))).ceil()
}