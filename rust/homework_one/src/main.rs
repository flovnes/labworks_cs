fn main() {
    //the real
}

fn _solution(input: f32) -> f32 {
    (input + input.powi(2)).acos()
}

#[test]
fn tests() {
    use std::f32::consts::PI;

    // x = 0, arccos(x+x^2) = pi/2
    assert_eq!(_solution(0.), PI/2.);
    // x = -1/2, arccos(x+x^2) ~ 1.82
    assert!(_solution(-0.5) > 1.8 && _solution(-0.5) < 1.9);
    // x = 0.618, arccos(x+x^2) ~ 0
    assert!(_solution(0.61803) < 0.01);
}
