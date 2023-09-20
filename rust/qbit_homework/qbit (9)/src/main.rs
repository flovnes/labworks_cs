use std::io;

fn main() {
    let (sides, thickness) = input_values();
    let quantity = solution((sides.0, sides.1, sides.2), thickness);

    println!("{}", quantity);
}

fn input_values() -> ((f32, f32, f32), f32) {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    let values: Vec<f32> = input_line
    .split_whitespace()
        .map(|q| q.parse().unwrap())
        .collect();
    ((values[0], values[1], values[2]), values[3])
}

fn solution(sides: (f32, f32, f32), thick: f32) -> f32 {
    let (a,b,c) = sides;
    
    let full_area: f32 = 2.*(a*b+b*c+a*c);
    (full_area/0.01*thick/1000.).ceil()
}