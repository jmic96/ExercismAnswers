


def is_criticality_balanced(temperature, neutrons_emitted):
    return (
        temperature < 800
        and neutrons_emitted > 500
        and temperature * neutrons_emitted < 500_000
    )

def reactor_efficiency(voltage, current, theoretical_max_power):
    generated_power = voltage * current
    band_color = generated_power / theoretical_max_power

    if band_color >= 0.8:
        return "green"
    elif 0.6 <= band_color < 0.8:
        return "orange"
    elif 0.3 <= band_color < 0.6:
        return "red"
    else:
        return "black"
        
def fail_safe(temperature, neutrons_produced_per_second, threshold):
    output = temperature*neutrons_produced_per_second
    low_thresh = threshold * 0.9
    high_thresh = threshold * 1.1
    
    if output < low_thresh:
        return "LOW"
    elif low_thresh <= output <= high_thresh:
        return "NORMAL"
    else:
        return "DANGER"